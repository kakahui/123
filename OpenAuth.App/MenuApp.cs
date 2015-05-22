﻿// ***********************************************************************
// Assembly         : OpenAuth.App
// Author           : yubaolee
// Created          : 05-19-2015
//
// Last Modified By : yubaolee
// Last Modified On : 05-20-2015
// ***********************************************************************
// <copyright file="MenuApp.cs" company="Microsoft">
//     Copyright (c) Microsoft. All rights reserved.
// </copyright>
// <summary>菜单服务</summary>
// ***********************************************************************
using System.Collections.Generic;
using OpenAuth.App.DTO;
using OpenAuth.Domain.Model;
using OpenAuth.Domain.Service;

namespace OpenAuth.App
{
    public class MenuApp
    {
        private MenuService _menuService;

        public MenuApp(MenuService service)
        {
            _menuService = service;
        }
        public MenuForUserResponse LoadFor(MenuForUserRequest request)
        {
            var response = new MenuForUserResponse();
            foreach (var menu in _menuService.GetMenuFor(request.UserId))
            {
                response.Menus.Add(menu);
            }
            return response;
        }
    }
}