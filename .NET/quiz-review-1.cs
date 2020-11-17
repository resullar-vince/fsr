// Tell your thoughts about how the class was created
// Would you change the code? if yes, what would be the changes.

class StudentSettings
{
  private Student uStudent;

  public StudentSettings(Student st)
  {
    uStudent = st;
  }

  public void ChangeSettings(Settings settings)
  {
    if (VerifyCredentials())
    {
      try
      {
        // Change Settings
      }
      catch (Exception ex)
      {
        if (ex is SettingsUpdaterException)
        {
          logger.logInfo(ex);
          throw ex;
        }
        else if (ex is SettingsJobHandlerException)
        {
          NotifyUserOfError(ex);
          throw ex;
        }
      }
    }
  }

  private bool VerifyCredentials()
  {
    // ...verifying credentials...
  }
}