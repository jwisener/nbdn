namespace nothinbutdotnetprep.infrastructure.searching
{
    public class AndSpecification<T> : BinarySpecification<T>
    {
        public AndSpecification(Specification<T> left_side, Specification<T> right_side) : base(left_side, right_side)
        {}

        public override bool is_satisfied_by(T item)
        {
            return left_side.is_satisfied_by(item) && right_side.is_satisfied_by(item);
        }
    }
}