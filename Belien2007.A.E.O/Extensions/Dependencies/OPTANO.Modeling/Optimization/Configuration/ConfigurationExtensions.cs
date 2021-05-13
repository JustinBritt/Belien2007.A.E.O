namespace Belien2007.A.E.O.Extensions.Dependencies.OPTANO.Modeling.Optimization.Configuration
{
    public static class ConfigurationExtensions
    {
        public static global::OPTANO.Modeling.Optimization.Configuration.Configuration WithComputeRemovedVariables(
            this global::OPTANO.Modeling.Optimization.Configuration.Configuration configuration)
        {
            configuration.ComputeRemovedVariables = true;

            return configuration;
        }

        public static global::OPTANO.Modeling.Optimization.Configuration.Configuration WithCopySolutionToModel(
            this global::OPTANO.Modeling.Optimization.Configuration.Configuration configuration)
        {
            configuration.CopySolutionToModel = true;

            return configuration;
        }

        public static global::OPTANO.Modeling.Optimization.Configuration.Configuration WithRestoreUserModelAfterSolve(
            this global::OPTANO.Modeling.Optimization.Configuration.Configuration configuration)
        {
            configuration.RestoreUserModelAfterSolve = true;

            return configuration;
        }

        public static global::OPTANO.Modeling.Optimization.Configuration.Configuration WithUniqueLongNames(
            this global::OPTANO.Modeling.Optimization.Configuration.Configuration configuration)
        {
            configuration.NameHandling = global::OPTANO.Modeling.Optimization.Configuration.NameHandlingStyle.UniqueLongNames;

            return configuration;
        }

        public static global::OPTANO.Modeling.Optimization.Configuration.Configuration WithUniqueShortNames(
            this global::OPTANO.Modeling.Optimization.Configuration.Configuration configuration)
        {
            configuration.NameHandling = global::OPTANO.Modeling.Optimization.Configuration.NameHandlingStyle.UniqueShortNames;

            return configuration;
        }

        public static global::OPTANO.Modeling.Optimization.Configuration.Configuration WithoutComputeRemovedVariables(
            this global::OPTANO.Modeling.Optimization.Configuration.Configuration configuration)
        {
            configuration.ComputeRemovedVariables = false;

            return configuration;
        }

        public static global::OPTANO.Modeling.Optimization.Configuration.Configuration WithoutCopySolutionToModel(
            this global::OPTANO.Modeling.Optimization.Configuration.Configuration configuration)
        {
            configuration.CopySolutionToModel = false;

            return configuration;
        }

        public static global::OPTANO.Modeling.Optimization.Configuration.Configuration WithoutRestoreUserModelAfterSolve(
            this global::OPTANO.Modeling.Optimization.Configuration.Configuration configuration)
        {
            configuration.RestoreUserModelAfterSolve = false;

            return configuration;
        }
    }
}