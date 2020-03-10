﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionConcours.Models
{
    public class Baccalaureat
    {
        [Key, ForeignKey("Candidat")]
        public string Cne { get; set; }
        public string TypeBac { get; set; }
        public DateTime DateObtentionBac { get; set; }
        public double NoteBac { get; set; }
        public string MentionBac { get; set; }


        public virtual Candidat Candidat { get; set; }

    }
}