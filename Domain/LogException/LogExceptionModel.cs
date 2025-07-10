using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.LogException;
public class LogExceptionModel:AuditableEntity,IAggregateRoot
{
    public long Id { get; private set; }
    
    public string InnerException { get; private set; }
    [StringLength(100)]

    public string? ErrorCode { get; private set; }
    [StringLength(500)]

    public string? ErrorMessage { get; private set; }
    public DateTime? ErrorDatetime { get; private set; }
    [StringLength(100)]

    public string? ControllerName { get; private set; }
    [StringLength(100)]

    public string? ActionName { get; private set; }
    public string? ExtraData { get; private set; }

    public LogExceptionModel(
     long Id,
     string InnerException,
     string? ErrorCode,
     string? ErrorMessage,
     DateTime? ErrorDatetime,
     string? ControllerName,
     string? ActionName,
     string? ExtraData
        )
    {
        this.Id = Id;
        this.InnerException = InnerException;
        this.ErrorCode = ErrorCode;
        this.ErrorMessage = ErrorMessage;
        this.ErrorDatetime = ErrorDatetime;
        this.ControllerName = ControllerName;
        this.ActionName = ActionName;
        this.ExtraData = ExtraData;

    }

    public LogExceptionModel Update(
    string InnerException,
    string? ErrorCode,
    string? ErrorMessage,
    DateTime? ErrorDatetime,
    string? ControllerName,
    string? ActionName,
    string? ExtraData
       )
    {
        this.InnerException = InnerException;
        this.ErrorCode = ErrorCode;
        this.ErrorMessage = ErrorMessage;
        this.ErrorDatetime = ErrorDatetime;
        this.ControllerName = ControllerName;
        this.ActionName = ActionName;
        this.ExtraData = ExtraData;
        return this;
    }
}

