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
        public int id {  get; set; }

        [Column("FullName_f")]
        public string fullName { get; set; }

        [Column("Mass_f")]
        public float? mass { get; set; }

        [Column("NamedAfter_f")]
        public string namedAfter {  get; set; }

        public ChemicalElements() { }

        public override string ToString()
        {
            return $"ID: {id}, Full Name: {fullName}, Mass: {mass?.ToString() ?? "N/A"}, Named After: {namedAfter}";
        }
    }
}
