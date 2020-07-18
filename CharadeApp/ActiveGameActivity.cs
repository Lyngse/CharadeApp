using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace CharadeApp
{
    [Activity(Label = "ActiveGameActivity", ScreenOrientation = ScreenOrientation.Landscape, NoHistory = true)]
    public class ActiveGameActivity : Activity
    {
        private List<string> categoryItems;
        private string categoryStringId;
        private GetCategoryItems gci;
        private TextView activeItem;
        private Button btnNext;
        private Button btnSkip;
        private ImageButton btnBack;
        private Dialog confirmDialog;
        private Dialog newRoundDialog;
        private Dialog finishedGameDialog;
        private System.Timers.Timer countDownTimer;
        private int startTime;
        private int timeLeft;
        private TextView txtTimer;
        private bool isWithTime;
        private bool isConfirmOpen = false;
        private List<string> customItems;
        private int skips;
        private int teamOneScore;
        private int teamTwoScore;
        private int currentTeam;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.active_game);

            //Window.DecorView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.HideNavigation;

            categoryItems = new List<string>();
            gci = new GetCategoryItems();

            categoryStringId = Intent.GetStringExtra("category");
            string withTime = Intent.GetStringExtra("withTime");
            if (withTime == "true")
            {
                isWithTime = true;
                startTime = Intent.GetIntExtra("time", 60);
            }
            else
            {
                isWithTime = false;
            }

            if (categoryStringId == "CustomCategory")
            {
                customItems = new List<string>();
                var ci = JsonConvert.DeserializeObject<List<string>>(Intent.GetStringExtra("list"));
                for (int i = 0; i < ci.Count; i++)
                {
                    categoryItems.Add(ci[i]);
                    customItems.Add(ci[i]);
                }
            }
            else
            {
                categoryItems = gci.GetItems(categoryStringId);
            }

            ShuffleList();

            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            this.Window.AddFlags(WindowManagerFlags.LayoutInScreen);
            this.Window.AddFlags(WindowManagerFlags.KeepScreenOn);

            //int uiOptions = (int)Window.DecorView.SystemUiVisibility;
            //uiOptions |= (int)SystemUiFlags.LowProfile;
            //uiOptions |= (int)SystemUiFlags.Fullscreen;
            //uiOptions |= (int)SystemUiFlags.HideNavigation;
            //uiOptions |= (int)SystemUiFlags.Immersive;
            //uiOptions |= (int)SystemUiFlags.LayoutHideNavigation;
            //uiOptions |= (int)SystemUiFlags.ImmersiveSticky;
            //Window.DecorView.SystemUiVisibility = (StatusBarVisibility)uiOptions;

            confirmDialog = new Dialog(this);
            confirmDialog.SetContentView(Resource.Layout.back_confirm);
            newRoundDialog = new Dialog(this);
            finishedGameDialog = new Dialog(this);
            finishedGameDialog.SetContentView(Resource.Layout.finished_game_popup);

            activeItem = (TextView)FindViewById<TextView>(Resource.Id.active_game_item_text);
            btnNext = (Button)FindViewById<Button>(Resource.Id.active_game_btn_next);
            btnSkip = (Button)FindViewById<Button>(Resource.Id.active_game_btn_skip);
            btnBack = (ImageButton)FindViewById<ImageButton>(Resource.Id.active_game_back_btn);
            txtTimer = (TextView)FindViewById<TextView>(Resource.Id.active_game_timer);

            if (isWithTime)
            {
                
                timeLeft = startTime;
                RunOnUiThread(() =>
                {
                    txtTimer.Text = timeLeft.ToString();
                });
                countDownTimer = new System.Timers.Timer();
                countDownTimer.Interval = 1000;
                countDownTimer.Elapsed += OnTimedEvent;
                countDownTimer.Enabled = true;
                newRoundDialog = new Dialog(this);
                newRoundDialog.SetContentView(Resource.Layout.new_round_popup);
                finishedGameDialog.SetContentView(Resource.Layout.finished_game_with_time_popup);
                //skips = 3;
            }
            else
            {
                txtTimer.Visibility = ViewStates.Invisible;
            }

            DrawItem();

            btnNext.Click += (sender, e) =>
            {
                NextItem();
            };

            btnSkip.Click += (sender, e) =>
            {
                SkipItem();
            };

            btnBack.Click += (sender, e) =>
            {
                isConfirmOpen = true;
                ShowConfirmPopup();
            };

            if(isWithTime)
            {
                countDownTimer.Stop();
                RunOnUiThread(() =>
                {
                    ShowPopup("newRound");
                });
            } 
        }

        private void OnTimedEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            timeLeft--;        
            RunOnUiThread(() =>
            {
                txtTimer.Text = timeLeft.ToString();
            });
            if (timeLeft == 0)
            {
                countDownTimer.Stop();
                if(!isConfirmOpen)
                {
                    RunOnUiThread(() =>
                    {
                        ShowPopup("newRound");
                    });
                }
            }
        }

        private void ShuffleList()
        {
            Random rng = new Random();

            for (int i = 0; i < categoryItems.Count; i++)
            {
                int k = rng.Next(categoryItems.Count);
                string temp = categoryItems[k];
                categoryItems[k] = categoryItems[i];
                categoryItems[i] = temp;
            }
        }

        private void DrawItem()
        {
            activeItem.Text = categoryItems[0];
        }

        private void SkipItem(bool fromNewRoundPopup = false)
        {
            if (categoryItems.Count > 1)
            {
                //if (isWithTime && fromNewRoundPopup == false)
                //{
                //    if (skips > 0)
                //    {
                //        ShuffleList();
                //        DrawItem();
                //        skips--;
                //        if (skips > 0)
                //            Toast.MakeText(this, "Du har " + skips.ToString() + " pas tilbage!", ToastLength.Short).Show();
                //        else
                //            Toast.MakeText(this, "Du har ikke flere pas tilbage!", ToastLength.Short).Show();
                //    }
                //    else
                //    {
                //        Toast.MakeText(this, "Du har ikke flere pas tilbage!", ToastLength.Short).Show();
                //    }
                //}
                //else
                //{
                //    ShuffleList();
                //    DrawItem();
                //}
                ShuffleList();
                DrawItem();
            }
        }

        private void NextItem()
        {
            if (currentTeam == 1)
                teamOneScore++;
            else
                teamTwoScore++;
            categoryItems.RemoveAt(0);
            if (categoryItems.Count == 1)
            {
                btnSkip.Enabled = false;
            }

            if (categoryItems.Count > 0)
            {
                DrawItem();
            }
            else
            {
                RunOnUiThread(() =>
                {
                    ShowPopup("finishedGame");
                });
            }
        }

        public void ShowPopup(string popupType)
        {
            if(popupType == "newRound")
            {
                newRoundDialog.SetContentView(Resource.Layout.new_round_with_time_popup);

                newRoundDialog.SetCanceledOnTouchOutside(false);

                TextView txtTitle;
                TextView t1s;
                TextView t2s;
                Button btnStart;

                txtTitle = (TextView)newRoundDialog.FindViewById(Resource.Id.nrwt_text);
                t1s = (TextView)newRoundDialog.FindViewById(Resource.Id.nrtw_team1_score);
                t2s = (TextView)newRoundDialog.FindViewById(Resource.Id.nrtw_team2_score);
                btnStart = (Button)newRoundDialog.FindViewById(Resource.Id.start_nrwt_btn);

                t1s.Text = teamOneScore.ToString();
                t2s.Text = teamTwoScore.ToString();
                if (currentTeam == 1)
                    currentTeam = 2;
                else
                    currentTeam = 1;

                if (currentTeam == 1)
                    txtTitle.Text = "Hold 1 gør jer klar!";
                else
                    txtTitle.Text = "Hold 2 gør jer klar!";

                btnStart.Click += (o, e) =>
                {
                    timeLeft = startTime;
                    SkipItem(true);
                    //skips = 3;
                    countDownTimer.Start();
                    RunOnUiThread(() =>
                    {
                        txtTimer.Text = timeLeft.ToString();
                    });
                    newRoundDialog.Dismiss();
                };

                newRoundDialog.Show();
            }
            else if(popupType == "finishedGame")
            {
                Button btnReplay;
                Button btnMainMenu;
                TextView txtTitle;
                TextView t1s;
                TextView t2s;
                if (isWithTime)
                {
                    finishedGameDialog.SetContentView(Resource.Layout.finished_game_with_time_popup);
                    countDownTimer.Stop();
                    txtTitle = (TextView)finishedGameDialog.FindViewById(Resource.Id.fgwt_text);
                    btnReplay = (Button)finishedGameDialog.FindViewById(Resource.Id.fgwt_start_new_game_btn);
                    btnMainMenu = (Button)finishedGameDialog.FindViewById(Resource.Id.fgwt_main_menu_btn);
                    t1s = (TextView)finishedGameDialog.FindViewById(Resource.Id.fgwt_team1_score);
                    t2s = (TextView)finishedGameDialog.FindViewById(Resource.Id.fgwt_team2_score);
                    RunOnUiThread(() =>
                    {
                        t1s.Text = teamOneScore.ToString();
                        t2s.Text = teamTwoScore.ToString();
                        if (teamOneScore > teamTwoScore)
                            txtTitle.Text = "Hold 1 vandt!";
                        else if (teamTwoScore > teamOneScore)
                            txtTitle.Text = "Hold 2 vandt!";
                        else
                            txtTitle.Text = "Uafgjort!";
                    });
                }
                else
                {
                    finishedGameDialog.SetContentView(Resource.Layout.finished_game_popup);
                    btnReplay = (Button)finishedGameDialog.FindViewById(Resource.Id.start_new_game_btn);
                    btnMainMenu = (Button)finishedGameDialog.FindViewById(Resource.Id.main_menu_btn);
                }

                finishedGameDialog.SetCanceledOnTouchOutside(false);                

                btnMainMenu.Click += (o, e) =>
                {
                    var intent = new Intent(this, typeof(MainActivity));
                    StartActivity(intent);
                };

                btnReplay.Click += (o, e) =>
                {
                    if(categoryStringId == "CustomCategory")
                    {
                        for (int i = 0; i < customItems.Count; i++)
                        {
                            categoryItems.Add(customItems[i]);
                        }
                    }
                    else
                    {
                        categoryItems = gci.GetItems(categoryStringId);
                    }
                    btnSkip.Enabled = true;
                    ShuffleList();
                    DrawItem();
                    if(isWithTime)
                    {
                        timeLeft = startTime;
                        //skips = 3;
                        countDownTimer.Start();
                        teamOneScore = 0;
                        teamTwoScore = 0;
                        currentTeam = 1;
                    }
                    finishedGameDialog.Dismiss();
                };
                finishedGameDialog.Show();
            }
        }

        public void ShowConfirmPopup()
        {
            confirmDialog.SetContentView(Resource.Layout.back_confirm);

            Button btnNo;
            Button btnYes;

            btnNo = (Button)confirmDialog.FindViewById(Resource.Id.confirm_no);
            btnYes = (Button)confirmDialog.FindViewById(Resource.Id.confirm_yes);

            btnYes.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };

            btnNo.Click += (o, e) =>
            {
                confirmDialog.Dismiss();
                isConfirmOpen = false;
                if (timeLeft == 0)
                {
                    RunOnUiThread(() =>
                    {
                        ShowPopup("newRound");
                    });
                }
            };
            confirmDialog.Show();
        }
    }
}