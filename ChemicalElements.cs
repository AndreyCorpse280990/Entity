using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("ChemicalElements_t")]
    internal class ChemicalElements
    {
        [Column("id")]
        public int Id {  get; set; }

        [Column("FullName_f")]
        public string FullName { get; set; } = string.Empty;

        [Column("Mass_f")]
        public double? Mass { get; set; }

        [Column("NamedAfter_f")]
        public string? NamedAfter {  get; set; }

        public ChemicalElements() { }

        public override string ToString()
        {
            return $"ID: {Id}, Full Name: {FullName}, Mass: {Mass}, Named After: {NamedAfter}";
        }
    }
}
