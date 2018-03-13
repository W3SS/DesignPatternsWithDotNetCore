namespace DesignPatterns.Shared.Patterns.Factory {
  public interface IPizza {
    void Prepare();
    void Bake();
    void Cut();
    void Box();
  }
}