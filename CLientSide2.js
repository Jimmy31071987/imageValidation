                   <asp:FileUpload runat="server" ID="Fupload" />
                   
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator7" 
                   runat="server" 
                   ControlToValidate="Fupload" 
                   ErrorMessage="Only .jpeg, .jpg, .gif, .png, .bitmap formats are allowed." 
                   ForeColor="Red" 
                   ValidationExpression="/^(([a-zA-Z]:)|(\\{2}\w+)\$?)(\\(\w[\w].*))+(.jpeg|.JPEG|.gif|.GIF|.png|.PNG|.JPG|.jpg|.bitmap|.BITMAP)$/" 
                   ValidationGroup="PartnerProfileUpdate" 
                   SetFocusOnError="true">
                   </asp:RegularExpressionValidator>
       
