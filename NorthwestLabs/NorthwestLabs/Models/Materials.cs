using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Materials")]
    public class Materials
    {
        [Key]
        public int matID; 
        public String materialName; 
        public int inventory; 
        public Double cost; 

        //methods
        public void adjustInventory(String sMaterialName, int iNewInventory)
        {
            //method code here
        }
        public void adjustCost(String sMaterialName, Double dNewCost)
        {
            //method code here
        }
    }
}