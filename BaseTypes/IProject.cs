﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hudl.Ffmpeg.Filters.BaseTypes;
using Hudl.Ffmpeg.Command.BaseTypes;
using Hudl.Ffmpeg.Resources;
using Hudl.Ffmpeg.Resources.BaseTypes; 

namespace Hudl.Ffmpeg.BaseTypes
{
    public interface IProject : IFilterable
    {
        IReadOnlyList<IResource> Resources { get; }

        TypeA Add<TypeA>()
            where TypeA : IResource, new();

        TypeA Add<TypeA>(string path)
            where TypeA : IResource, new();

        TypeA Add<TypeA>(string path, TimeSpan length)
            where TypeA : IResource, new();

        TypeA Add<TypeA>(string path, TimeSpan length, TimeSpan startAt, TimeSpan endAt)
            where TypeA : IResource, new();

        TypeA Add<TypeA>(TypeA resource)
            where TypeA : IResource, new();

        IProject Remove<TypeA>(TypeA resource)
            where TypeA : IResource, new(); 

        IProject RemoveAt(int index);

        TimeSpan GetLength(); 

        ResourceList Render<TypeP>()
            where TypeP : ICommandProcessor, new();
    }
}
