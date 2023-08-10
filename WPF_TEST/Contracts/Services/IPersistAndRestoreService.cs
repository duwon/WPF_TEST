namespace WPF_TEST.Contracts.Services;

public interface IPersistAndRestoreService
{
    void RestoreData();

    void PersistData();
}
