﻿using NaiveBayesSpamFilter.Interfaces;
using Ninject.Modules;

namespace NaiveBayesSpamFilter.SpamFilter
{
    public class SpamFilterModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPathProvider>().To<ConstantPathProvider>();
            Bind<ITrainingSample>().To<FoldersTrainigSample>();
            Bind<IProbabilityProvider>().To<ProbabilityProvider>();
            Bind<IWordsExtractor>().To<WordsExtractor>();
            Bind<IWordsPreprocessor>().To<WordsPreprocessor>().InSingletonScope();
        }
    }
}