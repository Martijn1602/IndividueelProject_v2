using System.ComponentModel.DataAnnotations;

namespace OrderManagementApp.DesktopClient.Models
{
    public class User : IModel
    {
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }

        public int GetId()
        {
            return UserId;
        }

        public void SetId(int id)
        {
            UserId = id;
        }
    }
}
