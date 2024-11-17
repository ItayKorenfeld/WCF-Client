<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Site1.MainPage" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title> </title>
    <style>
body {font-family: Arial, Helvetica, sans-serif;}
h1{font-size:50px ; color:chocolate; }

/* Full-width input fields */
input[type=text], input[type=password] {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;
}

/* Set a style for all buttons */
button {
  background-color: #04AA6D;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 100%;
}

button:hover {
  opacity: 0.8;
}

/* Extra styles for the cancel button */
.cancelbtn {
  width: auto;
  padding: 10px 18px;
  background-color: #f44336;
}

/* Center the image and position the close button */
.imgcontainer {
  text-align: center;
  margin: 24px 0 12px 0;
  position: relative;
}

img.avatar {
  width: 40%;
  border-radius: 50%;
}

.container {
  padding: 16px;
}

span.psw {
  float: right;
  padding-top: 16px;
}

/* The Modal (background) */
.modal {
  display: none; /* Hidden by default */
  position: fixed; /* Stay in place */
  z-index: 1; /* Sit on top */
  left: 0;
  top: 0;
  width: 100%; /* Full width */
  height: 100%; /* Full height */
  overflow: auto; /* Enable scroll if needed */
  background-color: rgb(0,0,0); /* Fallback color */
  background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
  padding-top: 60px;
}

/* Modal Content/Box */
.modal-content {
  background-color: #fefefe;
  margin: 5% auto 15% auto; /* 5% from the top, 15% from the bottom and centered */
  border: 1px solid #888;
  width: 80%; /* Could be more or less, depending on screen size */
}

/* The Close Button (x) */
.close {
  position: absolute;
  right: 25px;
  top: 0;
  color: #000;
  font-size: 35px;
  font-weight: bold;
}

.close:hover,
.close:focus {
  color: red;
  cursor: pointer;
}
label{
    margin:auto;
    text-align:center;
        
}

/* Add Zoom Animation */
.animate {
  -webkit-animation: animatezoom 0.6s;
  animation: animatezoom 0.6s
}

@-webkit-keyframes animatezoom {
  from {-webkit-transform: scale(0)} 
  to {-webkit-transform: scale(1)}
}
  
@keyframes animatezoom {
  from {transform: scale(0)} 
  to {transform: scale(1)}
}

/* Change styles for span and cancel button on extra small screens */
@media screen and (max-width: 300px) {
  span.psw {
     display: block;
     float: none;
  }
  .cancelbtn {
     width: 100%;
  }
}
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
         <div class="imgcontainer">
    <%--<img src="C:\Users\Teacher\Desktop\LoginRegister\LoginRegister\3749aaa8ee129d7e919bddcc7e09cd36_XL.jpg" alt="Avatar" class="avatar"/>--%>
<h1>Welcome to hpusekeeper asistance</h1>
  </div>
        

 
    <label for="uname"><b>PhoneNumber</b></label>
    <input  type="text" id="pnum" placeholder="Enter PhoneNumber" name="uname" />

    <label for="psw"><b>Password</b></label>
    <input type="password" id="passw" placeholder="Enter Password" name="psw" />

    <asp:button Font-Size="20px" BackColor="#04AA6D" color="white" margin="8px 0" border="none" cursor="pointer" width="100%"  runat="server" OnClick="btnLogin_Click" Text="Login" type="submit"></asp:button>
        <asp:Label  Font-Size="25px" ForeColor="Red" ID="Label1"  runat="server" Visible="false" Text="Incorrect password or PN"></asp:Label>
    </form>
    
</body>

</html>
