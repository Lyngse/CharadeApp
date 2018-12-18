using Android;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace CharadeApp
{
    public class Adapter : RecyclerView.Adapter
    {
        public List<Category> categories = new List<Category>();
        public event EventHandler<int> ChooseCard;

        public Adapter(List<Category> _categories)
        {
            categories = _categories;
        }

        public override RecyclerView.ViewHolder
        OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            // Inflate the CardView for the photo:
            View itemView = LayoutInflater.From(parent.Context).
                        Inflate(Resource.Layout.category_card, parent, false);

            // Create a ViewHolder to hold view references inside the CardView:
            CardViewHolder vh = new CardViewHolder(itemView, OnChoose);
            return vh;
        }

        public override void
        OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            CardViewHolder vh = holder as CardViewHolder;

            // Load the photo image resource from the photo album:
            vh.BackgroundImage.SetImageResource(categories[position].Background);

            // Load the photo caption from the photo album:
            vh.CategoryCountText.Text = categories[position].GetCategoryCountText();

            vh.Title.Text = categories[position].Title;
        }

        public override int ItemCount
        {
            get { return categories.Count; }
        }

        void OnChoose(int position)
        {
            if (ChooseCard != null)
                ChooseCard(this, position);
        }

        public class CardViewHolder : RecyclerView.ViewHolder
        {
            public ImageView BackgroundImage { get; private set; }
            public TextView CategoryCountText { get; private set; }
            public TextView Title { get; private set; }
            public Button ChooseBtn { get; private set; }


            public CardViewHolder(View itemView, Action<int> listener) : base(itemView)
            {
                BackgroundImage = itemView.FindViewById<ImageView>(Resource.Id.card_background);
                CategoryCountText = itemView.FindViewById<TextView>(Resource.Id.card_count);
                Title = itemView.FindViewById<TextView>(Resource.Id.card_title);
                ChooseBtn = itemView.FindViewById<Button>(Resource.Id.btn_choose);

                ChooseBtn.Click += (sender, e) => listener(base.LayoutPosition);

                // itemView.Click += (sender, e) => listener(base.LayoutPosition);
            }
        }
    }
}