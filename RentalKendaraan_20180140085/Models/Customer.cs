using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140085.Models
{
    public partial class Customer
    {
        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama Customer tidak boleh kosong")]
        public string NamaCustomer { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Nama Alamat tidak boleh kosong")]
        public string Alamat { get; set; }
        [MinLength(10, ErrorMessage = "No HP minimal 10 angka")]
        [MaxLength(13, ErrorMessage = "No HP maksimal 113 angka")]
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public Gender IdCustomerNavigation { get; set; }
        public Peminjaman Peminjaman { get; set; }
    }
}
