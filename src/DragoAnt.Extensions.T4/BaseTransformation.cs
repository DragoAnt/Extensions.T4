#pragma warning disable S3220,S2325

namespace DragoAnt.Extensions.T4
{
    /// <summary>
    ///     Base class for this transformation. Copied from generated class
    /// </summary>
    public abstract class BaseTransformation : TransformationBase;

    public abstract class BaseTransformation<T> : BaseTransformation
    {
        /// <summary>
        ///     Object to transform
        /// </summary>
        public T Data { get; set; } = default!;
    }
}