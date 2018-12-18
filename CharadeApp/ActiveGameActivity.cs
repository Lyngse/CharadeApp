﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CharadeApp
{
    [Activity(Label = "ActiveGameActivity", ScreenOrientation = ScreenOrientation.Landscape)]
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
        private int timeLeft;
        private TextView txtTimer;
        private bool isWithTime;
        private bool isConfirmOpen = false;

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
            }
            else
            {
                isWithTime = false;
            }


            categoryItems = gci.GetItems(categoryStringId);
            ShuffleList();

            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            this.Window.AddFlags(WindowManagerFlags.LayoutInScreen);
            this.Window.AddFlags(WindowManagerFlags.KeepScreenOn);

            confirmDialog = new Dialog(this);
            confirmDialog.SetContentView(Resource.Layout.back_confirm);
            finishedGameDialog = new Dialog(this);
            finishedGameDialog.SetContentView(Resource.Layout.finished_game_popup);

            activeItem = (TextView)FindViewById<TextView>(Resource.Id.active_game_item_text);
            btnNext = (Button)FindViewById<Button>(Resource.Id.active_game_btn_next);
            btnSkip = (Button)FindViewById<Button>(Resource.Id.active_game_btn_skip);
            btnBack = (ImageButton)FindViewById<ImageButton>(Resource.Id.active_game_back_btn);
            txtTimer = (TextView)FindViewById<TextView>(Resource.Id.active_game_timer);

            if (isWithTime)
            {
                timeLeft = 60;
                countDownTimer = new System.Timers.Timer();
                countDownTimer.Interval = 1000;
                countDownTimer.Elapsed += OnTimedEvent;
                countDownTimer.Enabled = true;
                countDownTimer.Start();
                newRoundDialog = new Dialog(this);
                newRoundDialog.SetContentView(Resource.Layout.new_round_popup);
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
        }

        private void OnTimedEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            timeLeft--;
            txtTimer.Text = timeLeft.ToString();
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

        private void SkipItem()
        {
            if (categoryItems.Count > 1)
            {
                ShuffleList();
                DrawItem();
            }
        }

        private void NextItem()
        {
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
                newRoundDialog.SetContentView(Resource.Layout.new_round_popup);

                newRoundDialog.SetCanceledOnTouchOutside(false);

                Button btnStart;

                btnStart = (Button)newRoundDialog.FindViewById(Resource.Id.start_new_round_btn);

                btnStart.Click += (o, e) =>
                {
                    timeLeft = 60;
                    countDownTimer.Start();
                    txtTimer.Text = timeLeft.ToString();
                    newRoundDialog.Dismiss();
                };

                newRoundDialog.Show();
            }
            else if(popupType == "finishedGame")
            {
                finishedGameDialog.SetContentView(Resource.Layout.finished_game_popup);

                finishedGameDialog.SetCanceledOnTouchOutside(false);

                Button btnReplay;
                Button btnMainMenu;

                btnReplay = (Button)finishedGameDialog.FindViewById(Resource.Id.start_new_game_btn);
                btnMainMenu = (Button)finishedGameDialog.FindViewById(Resource.Id.main_menu_btn);

                btnMainMenu.Click += (o, e) =>
                {
                    var intent = new Intent(this, typeof(MainActivity));
                    StartActivity(intent);
                };

                btnReplay.Click += (o, e) =>
                {
                    categoryItems = gci.GetItems(categoryStringId);
                    ShuffleList();
                    DrawItem();
                    if(isWithTime)
                    {
                        timeLeft = 60;
                        countDownTimer.Start();
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