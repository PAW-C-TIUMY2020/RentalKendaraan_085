using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140085.Models
{
    public partial class Customer
    {
        public Customer ()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }

        [Required(ErrorMessage = "Nama Customer tidak boleh kosong")]
        [DisplayName("Nama Customer")]
        public string NamaCustomer { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        [DisplayName("NIK")]
        [Required(ErrorMessage = "NIK tidak boleh kosong")]
        public string Nik { get; set; }

        [Required(ErrorMessage = "Alamat tidak boleh kosong")]
        public string Alamat { get; set; }

        [MinLength(10, ErrorMessage = "No HP minimal 10 angka")]
        [MaxLength(13, ErrorMessage = "No HP maksimal 113 angka")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        [Required(ErrorMessage = "No Hp wajib diisi")]
        [DisplayName("No HP")]
        public string NoHp { get; set; }

        [DisplayName("Id Gender")]
        [Required(ErrorMessage = "Id Gender tidak boleh kosong")]
        public int IdGender { get; set; }

        public Gender IdCustomerNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
