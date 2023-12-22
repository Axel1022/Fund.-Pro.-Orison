class Utils
{
    public static void Repro(string audio)
    {
        audio = $"Audios/{audio}";
        System.Diagnostics.Process.Start(@"powershell", $@"-c (New-Object Media.SoundPlayer '{audio}').PlaySync();");
    }
}

