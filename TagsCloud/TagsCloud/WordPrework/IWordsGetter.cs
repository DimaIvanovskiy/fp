﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagsCloud.ErrorHandling;

namespace TagsCloud.WordPrework
{
    public interface IWordsGetter
    {
        IEnumerable<Result<string>> GetWords(params char[] delimiters);
    }
}
