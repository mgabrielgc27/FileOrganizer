namespace FileOrganize;

class File
{
    private string path;
    private string name;
    private EType EType;
    public string Path { get { return path; } set { path = value; } }
    public string Name { get { return name; } set { name = value; } }
    public EType Etype { get { return EType; } set { EType = value; } }

    public File(string path)
    {
        this.path = path;
        name = FilterName(this.path);
        EType = FilterType(this.path);
    }

    private EType FilterType(string path)
    {
        int firstIndex = (path.LastIndexOf(".") + 1);
        int length = (path.Length - firstIndex);
        string ex = path.Substring(firstIndex, length);
        if
        (ex == "ppxt" || ex == "doc" || ex == "docx" ||
         ex == "html" || ex == "htm" || ex == "txt")
            return EType.TEXT_FILE;
        else if
        (ex == "png" || ex == "pdf" || ex == "jpg" ||
         ex == "gif" || ex == "svg" || ex == "webp")
            return EType.IMAGE_FILE;
        else if
        (ex == "mp3" || ex == "mp4" || ex == "wma" ||
         ex == "wav")
            return EType.AUDIO_FILE;
        else if
        (ex == "wmv" || ex == "avi" || ex == "mov" ||
         ex == "mpg")
            return EType.VIDEO_FILE;

        return EType.OTHER_FILE;
    }

    private string FilterName(string path)
    {
        int firstIndex = (path.LastIndexOf(@"\") + 1);
        int length = (path.LastIndexOf('.') - firstIndex);
        string name = path.Substring(firstIndex, length);
        return name;
    }
}