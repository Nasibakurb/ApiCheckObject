namespace ApiAppl.Domain.Entity
{
    public class MioCategoryState
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int MioCategoryId { get; set; }
        public int PnStatusId { get; set; }
        public int StateChangeId { get; set; }

        public MIOCategory? MIOCategory { get; set; }
        public PnStatus? PnStatus { get; set; }
        public MioCategoryStateChenges? MioCategoryStateChenges { get; set; }
    }

}

