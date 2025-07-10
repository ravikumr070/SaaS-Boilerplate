using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EmailLog;
public class EmailLogModel : AuditableEntity, IAggregateRoot
{
    public int Id { get;  set; }


    public int Email_Log_Id { get; private set; }
    [StringLength(200)]
    public string? Customer_Name { get; private set; }
    [StringLength(200)]

    public string Customer_Email { get; private set; }
    [StringLength(500)]


    public string? Email_Subject { get; private set; }
    public string? Email_body { get; private set; }

    public DateTime? Email_date { get; private set; }
    public string Customer_EmailBCC { get; private set; }

    public string ErrorMSG { get; private set; }

    public bool IsMailSent { get; private set; }

    public EmailLogModel(
           int Id,


     int Email_Log_Id,
     string? Customer_Name,
     string Customer_Email,

     string? Email_Subject,
     string? Email_body,

     DateTime? Email_date,
     string Customer_EmailBCC,

     string ErrorMSG,

     bool IsMailSent

        )
    {
        this.Id = Id;


        this.Email_Log_Id = Email_Log_Id;
        this.Customer_Name = Customer_Name;
        this.Customer_Email = Customer_Email;

        this.Email_Subject = Email_Subject;
        this.Email_body = Email_body;

        this.Email_date = Email_date;
        this.Customer_EmailBCC = Customer_EmailBCC;

        this.ErrorMSG = ErrorMSG;

        this.IsMailSent = IsMailSent;
    }

    public EmailLogModel Update(


     int Email_Log_Id,
     string? Customer_Name,
     string Customer_Email,

     string? Email_Subject,
     string? Email_body,

     DateTime? Email_date,
     string Customer_EmailBCC,

     string ErrorMSG,

     bool IsMailSent

        )
    {


        this.Email_Log_Id = Email_Log_Id;
        this.Customer_Name = Customer_Name;
        this.Customer_Email = Customer_Email;

        this.Email_Subject = Email_Subject;
        this.Email_body = Email_body;

        this.Email_date = Email_date;
        this.Customer_EmailBCC = Customer_EmailBCC;

        this.ErrorMSG = ErrorMSG;

        this.IsMailSent = IsMailSent;
        return this;
    }
}