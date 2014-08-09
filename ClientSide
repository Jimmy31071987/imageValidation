<script type="text/javascript">

    var validFilesTypes = ["bmp", "gif", "png", "jpg", "jpeg", "JPEG", "PNG", "GIF", "BMP"];

    function ValidateFile() {

        var file = document.getElementById("<%=Fupload.ClientID%>");

        var path = file.value;
        var ext = path.substring(path.lastIndexOf(".") + 1, path.length).toLowerCase();
        var isValidFile = false;
        for (var i = 0; i < validFilesTypes.length; i++) {
            if (ext == validFilesTypes[i]) {
                isValidFile = true;
                break;
            }
        }
        try {
            if ($(".std-notifySuccess") != null && $(".std-notifySuccess").find("span").length > 0) {
                $(".std-notifySuccess").hide();
            }
        }
        catch (e) {

        }

        if (!isValidFile) {
            $("#notifyClient").html("Please upload Team Member Image of type bmp,jpeg,png,gif");
            $("#notifyClient").addClass("topbottomMargin");
        }


        return isValidFile;

    }
</script>
