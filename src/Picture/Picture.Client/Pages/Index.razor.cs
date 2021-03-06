﻿using AntDesign;
using Microsoft.AspNetCore.Components;
using Picture.Client.Serivices;
using Picture.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Picture.Client.Pages
{
    public partial class Index
    {
        [Inject]
        public IPictureService PictureService { get; set; }

        public int Count = 51;
        public int Page = 0;

        public bool InitLoading { get; set; } = true;

        public bool Loading { get; set; } = false;

        public List<PictureItem360> Pictures { get; set; } = new List<PictureItem360>();

        private ListGridType gutter = new ListGridType
        {
            Xs = 3,
            Sm = 3,
            Md = 3,
            Lg = 3,
            Xl = 3,
            Xxl = 3,
            Column = 3
        };
        protected override async Task OnInitializedAsync()
        {
            Pictures = await GetList();
            InitLoading = false;
            await base.OnInitializedAsync();
        }

        public async Task OnLoadMore()
        {
            Loading = true;
            Page = Page + Count;
            var res = await GetList();
            Pictures.AddRange(res);
            Loading = false;
        }

        public async Task<List<PictureItem360>> GetList()
        {
            try
            {
                var res = await PictureService.Get360PicNews(Page, Count);

                return res.data;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new List<PictureItem360>();
            }
        }
    }
}
