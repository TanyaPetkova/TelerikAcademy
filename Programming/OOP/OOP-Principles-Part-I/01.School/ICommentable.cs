﻿namespace _01.School
{
    using System.Collections.Generic;

    interface ICommentable
    {
         List<string> Comments { get; set; }
         void AddComment(string comment);
    }
}
