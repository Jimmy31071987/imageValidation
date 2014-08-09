ublic class ImageProcess{
    Dictionary<string, byte[]> imageHeader = new Dictionary<string, byte[]>();

    public ImageProcess(ref System.Web.UI.WebControls.FileUpload fuImage, ref System.Web.UI.WebControls.Label lblMessage)
    {

    imageHeader.Add("JPG", new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 });

    imageHeader.Add("JPEG", new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 });

    imageHeader.Add("PNG", new byte[] { 0x89, 0x50, 0x4E, 0x47 });

    imageHeader.Add("TIF", new byte[] { 0x49, 0x49, 0x2A, 0x00 });

    imageHeader.Add("TIFF", new byte[] { 0x49, 0x49, 0x2A, 0x00 });

    imageHeader.Add("GIF", new byte[] { 0x47, 0x49, 0x46, 0x38 });

    imageHeader.Add("BMP", new byte[] { 0x42, 0x4D });

    imageHeader.Add("ICO", new byte[] { 0x00, 0x00, 0x01, 0x00 });

 

    byte[] header;

    if (fuImage.HasFile)

    {

        // GET FILE EXTENSION

        string fileExt;

        fileExt = fuImage.FileName.Substring(fuImage.FileName.LastIndexOf('.') + 1).ToUpper();

 

        // CUSTOM VALIDATION GOES HERE BASED ON FILE EXTENSION IF ANY

        

        byte[] tmp = imageHeader[fileExt];

        header = new byte[tmp.Length];

 

        // GET HEADER INFORMATION OF UPLOADED FILE

        fuImage.FileContent.Read(header, 0, header.Length);

 

        if (CompareArray(tmp, header))

        {

            lblMessage.Text = "Valid ." + fileExt + " file.";

            // VALID HEADER INFORMATION 

            // CODE TO PROCESS FILE

        }

        else

        {

            lblMessage.Text = "Invalid ." + fileExt + " file.";

            // INVALID HEADER INFORMATION

        }

    }

    else

    {

        lblMessage.Text = "Please select image file.";

    }

}

 

private bool CompareArray(byte[] a1, byte[] a2)

{

    if (a1.Length != a2.Length)

        return false;

 

    for (int i = 0; i < a1.Length; i++)

    {

        if (a1[i] != a2[i])

            return false;

    }

 

    return true;

}
}
