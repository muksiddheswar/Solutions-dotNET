static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string result;
        if (department == null)
            if (id != null)
                result = $"[{id}] - {name} - OWNER";
            else
                result = $"{name} - OWNER";
        else
        {
            if (id != null)
                result = $"[{id}] - {name} - {department.ToUpper()}";
            else
                result = $"{name} - {department.ToUpper()}";
        }
        return result;
    }
}
