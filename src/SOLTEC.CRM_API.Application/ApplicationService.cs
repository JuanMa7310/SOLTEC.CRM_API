namespace SOLTEC.CRM_API.Application;

public abstract class ApplicationService
{
    protected void ValidateNotNull(object obj, string paramName)
    {
        if (obj == null)
        {
            throw new ArgumentNullException(paramName, "The provided parameter cannot be null.");
        }
    }
}
