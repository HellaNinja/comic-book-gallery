﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artists[] Artist { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber;
            }
            //Not defining a setter makes this property read only
        }

        //Creating a pathing method for images
        //series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}