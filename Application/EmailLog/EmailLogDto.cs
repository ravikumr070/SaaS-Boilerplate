using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmailLog;
public class EmailLogDto:IDto
{
    public int Id { get; set; }


    public int Email_Log_Id { get;  set; }
    public string? Customer_Name { get;  set; }
    public string Customer_Email { get;  set; }

    public string? Email_Subject { get;  set; }
    public string? Email_body { get;  set; }

    public DateTime? Email_date { get;  set; }
    public string Customer_EmailBCC { get;  set; }

    public string ErrorMSG { get;  set; }

    public bool IsMailSent { get;  set; }

}
