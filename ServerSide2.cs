// Fupload is an Id of WebContorl of type file.

 private String[] FilType = new String[] { ".png", ".jpg", ".jpeg", ".bmp", ".gif", ".bitmap" };
 String pd = System.IO.Path.GetExtension(Fupload.PostedFile.FileName);
 if (FilType.Contains(pd.ToLower()))
                {
                //Retrive Contents
                }
