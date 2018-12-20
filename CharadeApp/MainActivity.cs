using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.V7.Widget;
using System.Collections.Generic;
using System;
using Android.Views;
using Android.Content;
using Android.Content.PM;
using Newtonsoft.Json;

namespace CharadeApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : AppCompatActivity
    {
        RecyclerView recyclerView;
        RecyclerView.LayoutManager layoutManager;
        Adapter adapter;
        List<Category> categories;
        GetCategoryItems gci = new GetCategoryItems();
        Dialog myDialog;
        Dialog customCategoryDialog;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            this.Window.AddFlags(WindowManagerFlags.LayoutInScreen);
            this.Window.AddFlags(WindowManagerFlags.KeepScreenOn);

            int uiOptions = (int)Window.DecorView.SystemUiVisibility;
            uiOptions |= (int)SystemUiFlags.LowProfile;
            uiOptions |= (int)SystemUiFlags.Fullscreen;
            uiOptions |= (int)SystemUiFlags.HideNavigation;
            uiOptions |= (int)SystemUiFlags.Immersive;
            uiOptions |= (int)SystemUiFlags.LayoutHideNavigation;
            uiOptions |= (int)SystemUiFlags.ImmersiveSticky;
            Window.DecorView.SystemUiVisibility = (StatusBarVisibility)uiOptions;

            myDialog = new Dialog(this);
            myDialog.SetContentView(Resource.Layout.custompopup);
            customCategoryDialog = new Dialog(this);
            customCategoryDialog.SetContentView(Resource.Layout.custom_category_popup);

            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);

            // Plug in the linear layout manager:
            layoutManager = new LinearLayoutManager(this);
            recyclerView.SetLayoutManager(layoutManager);

            categories = new List<Category>();
            categories.Add(new Category("LeagueOfLegends", Resource.Drawable.LeagueOfLegends, "League of Legends", gci.LeagueOfLegendsCount(), gci.LeagueOfLegends()));
            categories.Add(new Category("MarvelCharacters", Resource.Drawable.MarvelCharacters, "Marvel karakterer", gci.MarvelCharactersCount(), gci.MarvelCharacters()));
            categories.Add(new Category("SportAthletes", Resource.Drawable.SportAthletes, "Sports atleter", gci.SportAthletesCount(), gci.SportAthletes()));
            categories.Add(new Category("StarWars", Resource.Drawable.StarWars, "Star Wars", gci.StarWarsCount(), gci.StarWars()));
            categories.Add(new Category("DisneyMoviesAndShows", Resource.Drawable.DisneyMovies, "Disney film og serier", gci.DisneyMoviesAndShowsCount(), gci.DisneyMoviesAndShows()));
            categories.Add(new Category("DisneyCharacters", Resource.Drawable.Disney, "Disney karakterer", gci.DisneyCharactersCount(), gci.DisneyCharacters()));
            categories.Add(new Category("GameOfThrones", Resource.Drawable.GoT, "Game of Thrones", gci.GameOfThronesCount(), gci.GameOfThrones()));
            categories.Add(new Category("Movies", Resource.Drawable.Movies, "Film", gci.MoviesCount(), gci.Movies()));
            categories.Add(new Category("Professions", Resource.Drawable.professions, "Jobs", gci.ProfessionsCount(), gci.Professions()));
            categories.Add(new Category("Brands", Resource.Drawable.brands, "Brands", gci.BrandsCount(), gci.Brands()));

            categories.Add(new Category("CustomCategory", Resource.Drawable.customItems, "Lav din egen kategori", gci.CustomCategoryCount(), gci.CustomCategory()));


            adapter = new Adapter(categories);
            adapter.ChooseCard += OnChooseCard;
            recyclerView.SetAdapter(adapter);
        }

        void OnChooseCard(object sender, int position)
        {
            int photoNum = position + 1;
            //Toast.MakeText(this, "Kategori nummer " + photoNum, ToastLength.Short).Show();
            if(position == categories.Count - 1)
            {
                ShowCustomCategoryPopup(categories[position]);
            }
            else
            {
                ShowPopup(categories[position]);
            }           
        }

        private void ShowCustomCategoryPopup(Category category)
        {
            customCategoryDialog.SetContentView(Resource.Layout.custom_category_popup);

            TextView txtClose;
            Button btnStart;
            ImageButton btnAdd;
            EditText inputField;
            TextView txtCardCount;
            bool isTimedGame = true;

            txtClose = (TextView)customCategoryDialog.FindViewById(Resource.Id.ccp_close);
            btnStart = (Button)customCategoryDialog.FindViewById(Resource.Id.ccp_start);
            btnAdd = (ImageButton)customCategoryDialog.FindViewById(Resource.Id.ccp_add);
            inputField = (EditText)customCategoryDialog.FindViewById(Resource.Id.ccp_input);
            txtCardCount = (TextView)customCategoryDialog.FindViewById(Resource.Id.ccp_card_count);

            txtCardCount.Text = gci.CustomCategoryCount().ToString() + " kort";

            Switch s = myDialog.FindViewById<Switch>(Resource.Id.time_switch);
            s.CheckedChange += delegate (object sender, CompoundButton.CheckedChangeEventArgs e)
            {
                if (e.IsChecked == true)
                {
                    isTimedGame = true;
                }
                else
                {
                    isTimedGame = false;
                }
            };

            btnAdd.Click += (sender, e) =>
            {
                if(inputField.Text != "")
                {
                    gci.AddCustomCategoryItem(inputField.Text);
                    inputField.Text = "";
                    txtCardCount.Text = gci.CustomCategoryCount().ToString() + " kort";
                    RunOnUiThread(() =>
                    {
                        category.CategoryCount = gci.CustomCategoryCount();
                        adapter.NotifyItemChanged(categories.Count - 1);
                    });
                }
            };

            btnStart.Click += (sender, e) =>
            {
                if(gci.CustomCategoryCount() > 0)
                {
                    var intent = new Intent(this, typeof(ActiveGameActivity));
                    intent.PutExtra("category", category.StringId);
                    intent.PutExtra("list", JsonConvert.SerializeObject(gci.CustomCategory()));
                    if (isTimedGame == true)
                    {
                        intent.PutExtra("withTime", "true");
                    }
                    else
                    {
                        intent.PutExtra("withTime", "false");
                    }
                    //gci.ResetCustomCategory();
                    StartActivity(intent);
                }            
            };

            txtClose.Click += (o, e) =>
            {
                customCategoryDialog.Dismiss();
            };

            customCategoryDialog.Show();
        }


        public void ShowPopup(Category category)
        {
            myDialog.SetContentView(Resource.Layout.custompopup);

            TextView txtClose;
            Button btnStart;
            TextView txtTitle;
            bool isTimedGame = true;

            txtClose = (TextView)myDialog.FindViewById(Resource.Id.popup_close);
            btnStart = (Button)myDialog.FindViewById(Resource.Id.popup_start);
            txtTitle = (TextView)myDialog.FindViewById(Resource.Id.popup_title);

            txtTitle.Text = category.Title;
            // Time switch
            Switch s = myDialog.FindViewById<Switch>(Resource.Id.time_switch);
            s.CheckedChange += delegate (object sender, CompoundButton.CheckedChangeEventArgs e)
            {
                if (e.IsChecked == true)
                {
                    isTimedGame = true;
                } 
                else
                {
                    isTimedGame = false;
                }
            };

            btnStart.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(ActiveGameActivity));
                intent.PutExtra("category", category.StringId);
                if (isTimedGame == true)
                {
                    intent.PutExtra("withTime", "true");
                }
                else
                {
                    intent.PutExtra("withTime", "false");
                }
                StartActivity(intent);
            };

            txtClose.Click += (o, e) =>
            {
                myDialog.Dismiss();
            };
            
            myDialog.Show();
        }
    }
}