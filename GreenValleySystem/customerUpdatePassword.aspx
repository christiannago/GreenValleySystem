<%@ Page Title="" Language="C#" MasterPageFile="~/CustomerPortal.Master" AutoEventWireup="true" CodeBehind="customerUpdatePassword.aspx.cs" Inherits="GreenValleySystem.customerUpdatePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card card-body mb-3">
        <div class="row justify-content-center">
            <div class="form-group col-md-4 col-md-offset-5 align-center ">
                <div class="row">
                    <div class="form-inline">
                        <asp:Label ID="labelPassword" class="col-md-4 text-right" runat="server" Text="Current Password" Width="300px" Style="text-align: right;"></asp:Label>
                        <asp:TextBox ID="txtPassword" class="form-control" PlaceHolder="Current Password" runat="server" TextMode="Password"></asp:TextBox>
                        <div class="form-check m-2">
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="form-inline">
                        <asp:Label ID="labelPassword1" class="col-md-4 text-right" runat="server" Text="New Password" Width="300px" Style="text-align: right;"></asp:Label>
                        <asp:TextBox ID="txtPassword1" class="form-control" PlaceHolder="New Password" runat="server" TextMode="Password"></asp:TextBox>
                        <div class="form-check m-2">
                        </div>
                    </div>
                </div>
                <div class="row justify-content-center">
                    <div class="row">
                        <div class="form-inline">
                            <asp:Button ID="btnSubmit" runat="server" Class="btn btn-primary btn-block mb-3" Text="Apply" OnClick="btnSubmit_Click" />
                        </div>
                    </div>
                </div>
                <div class="row justify-content-center">
                    <div class="row">
                        <div class="form-inline">
                    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </div>
    </div>
        </div>
</asp:Content>
