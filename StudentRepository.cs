namespace SolidPrinciples;

public class StudentRepository
{
    public bool Save()
    {
        Logger.Log("save");

        return true;
    }

    public bool Delete()
    {
        Logger.Log("Start Delete");
        Logger.Log("End Delete");

        return true;
    }
}