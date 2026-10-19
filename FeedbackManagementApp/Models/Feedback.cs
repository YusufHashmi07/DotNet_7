
using System.ComponentModel.DataAnnotations;

namespace FeedbackManagementApp.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a subject.")]
        public string Subject { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your feedback.")]
        [StringLength(500, ErrorMessage = "Feedback cannot exceed 500 characters.")]
        public string Message { get; set; } = string.Empty;

        [Range(1, 5, ErrorMessage = "Please select a rating from 1 to 5.")]
        public int Rating { get; set; }
    }
}
