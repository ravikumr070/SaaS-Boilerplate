using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.LogException;
public class LogExceptionDto:IDto
{

    public string InnerException { get;  set; }
    public string? ErrorCode { get;  set; }
    public string? ErrorMessage { get;  set; }
    public DateTime? ErrorDatetime { get;  set; }
    public string? ControllerName { get;  set; }
    public string? ActionName { get;  set; }
    public string? ExtraData { get;  set; }
}
