using System;
using System.ComponentModel.DataAnnotations;

namespace TerminoLo.Data
{
   public enum Freigabestatus
   {
      Vorschlag = 0,
      Offiziell = 1,
      Abgelehnt = 2
   }

   public class Begriff
   {
      [Key, Required]
      public Guid Id { get; set; }

      [StringLength(100)]
      public string Hauptbenennung { get; set; }

      [StringLength(400)]
      public string Vermeidungsliste { get; set; }

      public Freigabestatus Status { get; set; }
   }
}
