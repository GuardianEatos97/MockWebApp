﻿using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.SqlServer.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace MockWebApp.Models.Entities
{
    public class Excercise
    {
        public int ExcerciseId { get; set; }
        public string ExcerciseName { get; set; }
        public string ExcerciseDescription { get; set; }

        [ForeignKey(nameof(BodyPart))]
        public int BodyPartID { get; set; }
    }
}
