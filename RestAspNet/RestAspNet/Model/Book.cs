﻿using RestAspNet.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestAspNet.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {

        [Column("author")]
        public string Author { get; set; }

        [Column("launch_date")]
        public DateTime Launch_date{ get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("title")]
        public string Title { get; set; }

    }
}
