using System.ComponentModel.DataAnnotations;

namespace _02MVC.Models;

public class Emp
{
    [Key]
    public int No { get; set; }
    public string ?Name { get; set; }
    public string ?Address { get; set; }
}
