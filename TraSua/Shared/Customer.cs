using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TraSua.Shared
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập tên.")]
        public string Name { get; set; } = default;

        [Required(ErrorMessage = "Bạn chưa nhập địa chỉ.")]
        public string Street { get; set; } = default;

        [Required(ErrorMessage = "Bạn chưa nhập thành phố.")]
        public string City { get; set; } = default;
    }
}
