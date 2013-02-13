using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for IErrorMessage
/// </summary>
public interface IErrorMessage
{
    void SetError(Type context, string message);
    void SetError(Type context, Exception ex);
}