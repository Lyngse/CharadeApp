using System;
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
    [Activity(Label = "ActiveTimedGameActivity", ScreenOrientation = ScreenOrientation.Landscape)]
    public class ActiveTimedGameActivity : Activity
    {
        private List<string> categoryItems;
        private GetCategoryItems gci;
        private TextView activeItem;
        private Button btnNext;
        private Button btnSkip;
        private ImageButton btnBack;
        private Dialog confirmDialog;
        private Dialog newRoundDialog;
        private System.Timers.Timer countDownTimer;
        private int timeLeft = 2;
        private TextView txtTimer;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.active_timed_game);

            categoryItems = new List<string>();
            gci = new GetCategoryItems();

            string categoryStringId = Intent.GetStringExtra("category");

            categoryItems = gci.GetItems(categoryStringId);
            ShuffleList();

            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            this.Window.AddFlags(WindowManagerFlags.KeepScreenOn);

            confirmDialog = new Dialog(this);
            confirmDialog.SetContentView(Resource.Layout.back_confirm);
            newRoundDialog = new Dialog(this);
            newRoundDialog.SetContentView(Resource.Layout.new_round_popup);

            activeItem = (TextView)FindViewById<TextView>(Resource.Id.active_timed_game_item_text);
            btnNext = (Button)FindViewById<Button>(Resource.Id.active_timed_game_btn_next);
            btnSkip = (Button)FindViewById<Button>(Resource.Id.active_timed_game_btn_skip);
            btnBack = (ImageButton)FindViewById<ImageButton>(Resource.Id.active_timed_game_back_btn);
            txtTimer = (TextView)FindViewById<TextView>(Resource.Id.active_timed_game_timer);
            DrawItem();

            countDownTimer = new System.Timers.Timer();
            countDownTimer.Interval = 1000;
            countDownTimer.Elapsed += OnTimedEvent;
            countDownTimer.Enabled = true;
            countDownTimer.Start();

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
                countDownTimer.Stop();
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
                RunOnUiThread(() =>
                {
                    ShowNewRoundPopup();
                });
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
            if (categoryItems.Count == 1)
            {
                btnNext.Enabled = false;
                btnSkip.Enabled = false;
            }
        }

        private void SkipItem()
        {
            if (categoryItems.Count > 1)
            {
                ShuffleList();
                DrawItem();
            }
            else
            {
                // Show some alert or disable skip button, when there is only one button left
            }
        }

        private void NextItem()
        {
            categoryItems.RemoveAt(0);
            if (categoryItems.Count > 0)
            {
                DrawItem();
            }
            else
            {
                // Jump to a finish screen
            }
        }

        public void ShowNewRoundPopup()
        {
            newRoundDialog.SetContentView(Resource.Layout.new_round_popup);

            //newRoundDialog.SetCanceledOnTouchOutside(false);

            Button btnStart;

            btnStart = (Button)newRoundDialog.FindViewById(Resource.Id.start_new_round_btn);

            btnStart.Click += (o, e) =>
            {
                timeLeft = 60;
                countDownTimer.Start();
                newRoundDialog.Dismiss();
            };

            newRoundDialog.Show();
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
                if(timeLeft > 0)
                {
                    countDownTimer.Start();
                }
            };

            confirmDialog.Show();
        }
    }
}