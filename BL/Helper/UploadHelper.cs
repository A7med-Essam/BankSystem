namespace BankSystem.BL.Helper
{
    public static class UploadHelper
    {
        public static void Upload(IFormFile file)
        {
            if (file.Length > 0)
            {
                var path = Directory.GetCurrentDirectory() + "/wwwroot/uploads/" + Guid.NewGuid() + "_File_" + Path.GetFileName(file.FileName);
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
        }
    }
}
