namespace DeathlyEnterprises.Core.Serialization
{
    public interface ISerializer<TSerializerType>
    {
        TSerializerType Serialize<TObject>(TObject objectToSerialize);
        TObject Deserialize<TObject>(TSerializerType serializedObject);
    }
}