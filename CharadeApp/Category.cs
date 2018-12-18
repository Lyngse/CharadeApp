using System.Collections.Generic;

public class Category
{
    public string StringId { get; set; }
    public int Background { get; set; }
    public string Title { get; set; }
    public int CategoryCount { get; set; }
    public List<string> Items { get; set; }

    public Category()
    {

    }

    public Category(string stringId, int background, string title, int categoryCount, List<string> items)
    {
        this.StringId = stringId;
        this.Background = background;
        this.Title = title;
        this.CategoryCount = categoryCount;
        this.Items = items;
    }

    public string GetCategoryCountText()
    {
        return this.CategoryCount + " kort";
    }

}