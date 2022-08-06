using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Lasmart.Models
{
    public static class SampleData
    {
        public static void Initialize(PointContext context)
        {
            if (!context.Points.Any())
            {
                context.Points.AddRange(
                    new Point
                    {
                        Ox = 220,
                        Oy = 250,
                        Radius = 50,
                        Colour = "#ffc0cb"

                    },
                    new Point
                    {
                        Ox = 500,
                        Oy = 80,
                        Radius = 30,
                        Colour = "#ff0000"

                    }
                    );

                context.Comments.AddRange(
                new Comment
                {
                    Id = 1,
                    Text = "Comment 1",
                    BackgroundColor = null,
                    PointId = 1
                },
                new Comment
                {
                    Id = 2,
                    Text = "Comment 2",
                    BackgroundColor = "#ffff00",
                    PointId = 1
                },
                new Comment
                {
                    Id = 3,
                    Text = "Comment 3",
                    BackgroundColor = null,
                    PointId = 2
                },
                new Comment
                {
                    Id = 4,
                    Text = "Comment 4",
                    BackgroundColor = "Grey",
                    PointId = 2
                },
                new Comment
                {
                    Id = 5,
                    Text = "Comment 5",
                    BackgroundColor = null,
                    PointId = 2
                },
                new Comment
                {
                    Id = 6,
                    Text = "Comment 6 looooooooooooooooong comment",
                    BackgroundColor = "#ffff00",
                    PointId = 2
                },
                new Comment
                {
                    Id = 7,
                    Text = "Comment 7",
                    BackgroundColor = "Grey",
                    PointId = 2
                },
                new Comment
                {
                    Id = 8,
                    Text = "Comment 8",
                    BackgroundColor = null,
                    PointId = 2
                }
                    );

                context.SaveChanges();
            }

        }
    }
}
