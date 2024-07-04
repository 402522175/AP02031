#include <iostream>

using namespace std;

template <typename T>
class Matrix
{
private:
    T *data;
    size_t rows;
    size_t columns;

public:
    Matrix(size_t NRow, size_t NColumn) 
    : rows(NRow)
    , columns(NColumn)
    {
        data = new T[rows * columns];
    }

    ~Matrix()
    {
        delete[] data;
    }

    size_t NRow() const
    {
        return rows;
    }

    size_t NColumn() const
    {
        return columns;
    }

    T &at(size_t row, size_t col)

    const T &at(size_t row, size_t col) const;
    Matrix<T> add(const Matrix<T> &other) const {}
    Matrix<T> multiply(const Matrix<T> &other) const {}
    Matrix<T> multiply(const T &scalar) const {}
    Matrix<T> transpose() const {}
    void display() const {}
};
