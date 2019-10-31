public static class PipeExtensions
{ 
	/// <summary>
	/// Pipes 1 functions
	/// </summary>
	public static B Pipe<A,B>(this A obj, Func<A,B> func1) => func1(obj); 
	
	/// <summary>
	/// Pipes 2 functions
	/// </summary>
	public static C Pipe<A,B,C>(this A obj, Func<A,B> func1, Func<B,C> func2) => func2(func1(obj)); 
	
	/// <summary>
	/// Pipes 3 functions
	/// </summary>
	public static D Pipe<A,B,C,D>(this A obj, Func<A,B> func1, Func<B,C> func2, Func<C,D> func3) => func3(func2(func1(obj))); 
	
	/// <summary>
	/// Pipes 4 functions
	/// </summary>
	public static E Pipe<A,B,C,D,E>(this A obj, Func<A,B> func1, Func<B,C> func2, Func<C,D> func3, Func<D,E> func4) => func4(func3(func2(func1(obj)))); 
	
	/// <summary>
	/// Pipes 5 functions
	/// </summary>
	public static F Pipe<A,B,C,D,E,F>(this A obj, Func<A,B> func1, Func<B,C> func2, Func<C,D> func3, Func<D,E> func4, Func<E,F> func5) => func5(func4(func3(func2(func1(obj))))); 
	
	/// <summary>
	/// Pipes 6 functions
	/// </summary>
	public static G Pipe<A,B,C,D,E,F,G>(this A obj, Func<A,B> func1, Func<B,C> func2, Func<C,D> func3, Func<D,E> func4, Func<E,F> func5, Func<F,G> func6) => func6(func5(func4(func3(func2(func1(obj)))))); 
	
	/// <summary>
	/// Pipes 7 functions
	/// </summary>
	public static H Pipe<A,B,C,D,E,F,G,H>(this A obj, Func<A,B> func1, Func<B,C> func2, Func<C,D> func3, Func<D,E> func4, Func<E,F> func5, Func<F,G> func6, Func<G,H> func7) => func7(func6(func5(func4(func3(func2(func1(obj))))))); 
	
	/// <summary>
	/// Pipes 8 functions
	/// </summary>
	public static I Pipe<A,B,C,D,E,F,G,H,I>(this A obj, Func<A,B> func1, Func<B,C> func2, Func<C,D> func3, Func<D,E> func4, Func<E,F> func5, Func<F,G> func6, Func<G,H> func7, Func<H,I> func8) => func8(func7(func6(func5(func4(func3(func2(func1(obj)))))))); 
	
	/// <summary>
	/// Pipes 9 functions
	/// </summary>
	public static J Pipe<A,B,C,D,E,F,G,H,I,J>(this A obj, Func<A,B> func1, Func<B,C> func2, Func<C,D> func3, Func<D,E> func4, Func<E,F> func5, Func<F,G> func6, Func<G,H> func7, Func<H,I> func8, Func<I,J> func9) => func9(func8(func7(func6(func5(func4(func3(func2(func1(obj))))))))); 
	
	/// <summary>
	/// Pipes 10 functions
	/// </summary>
	public static K Pipe<A,B,C,D,E,F,G,H,I,J,K>(this A obj, Func<A,B> func1, Func<B,C> func2, Func<C,D> func3, Func<D,E> func4, Func<E,F> func5, Func<F,G> func6, Func<G,H> func7, Func<H,I> func8, Func<I,J> func9, Func<J,K> func10) => func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj)))))))))); 
	
	/// <summary>
	/// Pipes 11 functions
	/// </summary>
	public static L Pipe<A,B,C,D,E,F,G,H,I,J,K,L>(this A obj, Func<A,B> func1, Func<B,C> func2, Func<C,D> func3, Func<D,E> func4, Func<E,F> func5, Func<F,G> func6, Func<G,H> func7, Func<H,I> func8, Func<I,J> func9, Func<J,K> func10, Func<K,L> func11) => func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj))))))))))); 
	
	/// <summary>
	/// Pipes 12 functions
	/// </summary>
	public static M Pipe<A,B,C,D,E,F,G,H,I,J,K,L,M>(this A obj, Func<A,B> func1, Func<B,C> func2, Func<C,D> func3, Func<D,E> func4, Func<E,F> func5, Func<F,G> func6, Func<G,H> func7, Func<H,I> func8, Func<I,J> func9, Func<J,K> func10, Func<K,L> func11, Func<L,M> func12) => func12(func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj)))))))))))); 
	
	/// <summary>
	/// Pipes 13 functions
	/// </summary>
	public static N Pipe<A,B,C,D,E,F,G,H,I,J,K,L,M,N>(this A obj, Func<A,B> func1, Func<B,C> func2, Func<C,D> func3, Func<D,E> func4, Func<E,F> func5, Func<F,G> func6, Func<G,H> func7, Func<H,I> func8, Func<I,J> func9, Func<J,K> func10, Func<K,L> func11, Func<L,M> func12, Func<M,N> func13) => func13(func12(func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj))))))))))))); 
	
	/// <summary>
	/// Pipes 14 functions
	/// </summary>
	public static O Pipe<A,B,C,D,E,F,G,H,I,J,K,L,M,N,O>(this A obj, Func<A,B> func1, Func<B,C> func2, Func<C,D> func3, Func<D,E> func4, Func<E,F> func5, Func<F,G> func6, Func<G,H> func7, Func<H,I> func8, Func<I,J> func9, Func<J,K> func10, Func<K,L> func11, Func<L,M> func12, Func<M,N> func13, Func<N,O> func14) => func14(func13(func12(func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj)))))))))))))); 
	
	/// <summary>
	/// Pipes 15 functions
	/// </summary>
	public static P Pipe<A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P>(this A obj, Func<A,B> func1, Func<B,C> func2, Func<C,D> func3, Func<D,E> func4, Func<E,F> func5, Func<F,G> func6, Func<G,H> func7, Func<H,I> func8, Func<I,J> func9, Func<J,K> func10, Func<K,L> func11, Func<L,M> func12, Func<M,N> func13, Func<N,O> func14, Func<O,P> func15) => func15(func14(func13(func12(func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj))))))))))))))); 
	
	/// <summary>
	/// Pipes 16 functions
	/// </summary>
	public static Q Pipe<A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q>(this A obj, Func<A,B> func1, Func<B,C> func2, Func<C,D> func3, Func<D,E> func4, Func<E,F> func5, Func<F,G> func6, Func<G,H> func7, Func<H,I> func8, Func<I,J> func9, Func<J,K> func10, Func<K,L> func11, Func<L,M> func12, Func<M,N> func13, Func<N,O> func14, Func<O,P> func15, Func<P,Q> func16) => func16(func15(func14(func13(func12(func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj))))))))))))))));

	/// <summary>
	/// Pipes 17 functions
	/// </summary>
	public static R Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R>(this A obj, Func<A, B> func1, Func<B, C> func2, Func<C, D> func3, Func<D, E> func4, Func<E, F> func5, Func<F, G> func6, Func<G, H> func7, Func<H, I> func8, Func<I, J> func9, Func<J, K> func10, Func<K, L> func11, Func<L, M> func12, Func<M, N> func13, Func<N, O> func14, Func<O, P> func15, Func<P, Q> func16, Func<Q, R> func17) => func17(func16(func15(func14(func13(func12(func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj)))))))))))))))));

	/// <summary>
	/// Pipes 18 functions
	/// </summary>
	public static S Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S>(this A obj, Func<A, B> func1, Func<B, C> func2, Func<C, D> func3, Func<D, E> func4, Func<E, F> func5, Func<F, G> func6, Func<G, H> func7, Func<H, I> func8, Func<I, J> func9, Func<J, K> func10, Func<K, L> func11, Func<L, M> func12, Func<M, N> func13, Func<N, O> func14, Func<O, P> func15, Func<P, Q> func16, Func<Q, R> func17, Func<R, S> func18) => func18(func17(func16(func15(func14(func13(func12(func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj))))))))))))))))));

	/// <summary>
	/// Pipes 19 functions
	/// </summary>
	public static T Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T>(this A obj, Func<A, B> func1, Func<B, C> func2, Func<C, D> func3, Func<D, E> func4, Func<E, F> func5, Func<F, G> func6, Func<G, H> func7, Func<H, I> func8, Func<I, J> func9, Func<J, K> func10, Func<K, L> func11, Func<L, M> func12, Func<M, N> func13, Func<N, O> func14, Func<O, P> func15, Func<P, Q> func16, Func<Q, R> func17, Func<R, S> func18, Func<S, T> func19) => func19(func18(func17(func16(func15(func14(func13(func12(func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj)))))))))))))))))));

	/// <summary>
	/// Pipes 20 functions
	/// </summary>
	public static U Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U>(this A obj, Func<A, B> func1, Func<B, C> func2, Func<C, D> func3, Func<D, E> func4, Func<E, F> func5, Func<F, G> func6, Func<G, H> func7, Func<H, I> func8, Func<I, J> func9, Func<J, K> func10, Func<K, L> func11, Func<L, M> func12, Func<M, N> func13, Func<N, O> func14, Func<O, P> func15, Func<P, Q> func16, Func<Q, R> func17, Func<R, S> func18, Func<S, T> func19, Func<T, U> func20) => func20(func19(func18(func17(func16(func15(func14(func13(func12(func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj))))))))))))))))))));

	/// <summary>
	/// Pipes 21 functions
	/// </summary>
	public static V Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V>(this A obj, Func<A, B> func1, Func<B, C> func2, Func<C, D> func3, Func<D, E> func4, Func<E, F> func5, Func<F, G> func6, Func<G, H> func7, Func<H, I> func8, Func<I, J> func9, Func<J, K> func10, Func<K, L> func11, Func<L, M> func12, Func<M, N> func13, Func<N, O> func14, Func<O, P> func15, Func<P, Q> func16, Func<Q, R> func17, Func<R, S> func18, Func<S, T> func19, Func<T, U> func20, Func<U, V> func21) => func21(func20(func19(func18(func17(func16(func15(func14(func13(func12(func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj)))))))))))))))))))));

	/// <summary>
	/// Pipes 22 functions
	/// </summary>
	public static W Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W>(this A obj, Func<A, B> func1, Func<B, C> func2, Func<C, D> func3, Func<D, E> func4, Func<E, F> func5, Func<F, G> func6, Func<G, H> func7, Func<H, I> func8, Func<I, J> func9, Func<J, K> func10, Func<K, L> func11, Func<L, M> func12, Func<M, N> func13, Func<N, O> func14, Func<O, P> func15, Func<P, Q> func16, Func<Q, R> func17, Func<R, S> func18, Func<S, T> func19, Func<T, U> func20, Func<U, V> func21, Func<V, W> func22) => func22(func21(func20(func19(func18(func17(func16(func15(func14(func13(func12(func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj))))))))))))))))))))));

	/// <summary>
	/// Pipes 23 functions
	/// </summary>
	public static X Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X>(this A obj, Func<A, B> func1, Func<B, C> func2, Func<C, D> func3, Func<D, E> func4, Func<E, F> func5, Func<F, G> func6, Func<G, H> func7, Func<H, I> func8, Func<I, J> func9, Func<J, K> func10, Func<K, L> func11, Func<L, M> func12, Func<M, N> func13, Func<N, O> func14, Func<O, P> func15, Func<P, Q> func16, Func<Q, R> func17, Func<R, S> func18, Func<S, T> func19, Func<T, U> func20, Func<U, V> func21, Func<V, W> func22, Func<W, X> func23) => func23(func22(func21(func20(func19(func18(func17(func16(func15(func14(func13(func12(func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj)))))))))))))))))))))));

	/// <summary>
	/// Pipes 24 functions
	/// </summary>
	public static Y Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y>(this A obj, Func<A, B> func1, Func<B, C> func2, Func<C, D> func3, Func<D, E> func4, Func<E, F> func5, Func<F, G> func6, Func<G, H> func7, Func<H, I> func8, Func<I, J> func9, Func<J, K> func10, Func<K, L> func11, Func<L, M> func12, Func<M, N> func13, Func<N, O> func14, Func<O, P> func15, Func<P, Q> func16, Func<Q, R> func17, Func<R, S> func18, Func<S, T> func19, Func<T, U> func20, Func<U, V> func21, Func<V, W> func22, Func<W, X> func23, Func<X, Y> func24) => func24(func23(func22(func21(func20(func19(func18(func17(func16(func15(func14(func13(func12(func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj))))))))))))))))))))))));

	/// <summary>
	/// Pipes 25 functions
	/// </summary>
	public static Z Pipe<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z>(this A obj, Func<A, B> func1, Func<B, C> func2, Func<C, D> func3, Func<D, E> func4, Func<E, F> func5, Func<F, G> func6, Func<G, H> func7, Func<H, I> func8, Func<I, J> func9, Func<J, K> func10, Func<K, L> func11, Func<L, M> func12, Func<M, N> func13, Func<N, O> func14, Func<O, P> func15, Func<P, Q> func16, Func<Q, R> func17, Func<R, S> func18, Func<S, T> func19, Func<T, U> func20, Func<U, V> func21, Func<V, W> func22, Func<W, X> func23, Func<X, Y> func24, Func<Y, Z> func25) => func25(func24(func23(func22(func21(func20(func19(func18(func17(func16(func15(func14(func13(func12(func11(func10(func9(func8(func7(func6(func5(func4(func3(func2(func1(obj)))))))))))))))))))))))));

}