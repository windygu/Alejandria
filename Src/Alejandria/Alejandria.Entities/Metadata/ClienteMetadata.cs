﻿using System.ComponentModel.DataAnnotations;

namespace Alejandria.Entities
{
    [MetadataType(typeof(ClienteMetadata))]
    public partial class Cliente
    {
    }

    public class ClienteMetadata
    {
        [Required(ErrorMessage = "Debe ingresar una denominación")]
        public string Denominacion { get; set; }

        //[Required(ErrorMessage = "Debe ingresar una domicilio")]
        public string Domicilio { get; set; }

        [Required(ErrorMessage = "Debe ingresar un CUIT/DNI")]
        [MaxLength(11, ErrorMessage = "El número de cuit/DNI no es válido")]
        [RegularExpression("^[0-9]{8,11}?$", ErrorMessage = "El número de cuit/DNI no es válido")]
        public string Cuit { get; set; }

        [Required(ErrorMessage = "Debe ingresar un número de Cuenta")]
       // [MaxLength(4, ErrorMessage = "El número de cuenta no es válido")]
       // [RegularExpression("^[0-9]{8,11}?$", ErrorMessage = "El número de cuenta no es válido")]
        public int? Cuenta { get; set; }

        //[DataType(DataType.EmailAddress)]
        //[EmailAddress(ErrorMessage = "El email no es válido")]
        //public string Mail { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una opción")]
        [Range(1, 5000, ErrorMessage = "Debe seleccionar una opción")]
        public int? LocalidadId { get; set; }

        [MaxLength(15, ErrorMessage = "Debe tener como máximo 15 elementos")]
        public string Celular { get; set; }
    }
}
