public class PhanSo
{
    // field
    private int _tuSo;
    private int _mauSo;
    // Properties
    public int tuSo
    {
        get
        {
            return _tuSo;
        }
        set
        {
            _tuSo = value;
        }
    }
    public int mauSo
    {
        get
        {
            return _mauSo;
        }
        set
        {
            if(mauSo != 0)
            {
                _mauSo = value;
            }
            else
            {
                _mauSo = 1;
            }
            
        }
    }
    public PhanSo(int tu, int mau)
    {
        this._tuSo = tu;
        if(mau != 0)
        {
            this._mauSo = mau;
        }
        else
        {
            mau = 1;
        }
        
    }
    public PhanSo()
    {
        this._tuSo = 0;
        this._mauSo = 1;
    }
    public PhanSo(int tu)
    {
        this._tuSo = tu;
        this._mauSo = 1;
    }
    // Methods
    public string toString()
    {
        if(this._mauSo < 0)
        {
            this._tuSo = (-1) * this._tuSo;
            this._mauSo = (-1) * this._mauSo;
        }
        if(this._mauSo == 1 || this._tuSo == 0)
        {
            return ($"{this._tuSo}");
        }
        return ($"{this._tuSo}/{this._mauSo}");
    }
    
    // Cong 2 phan so
    public PhanSo CongPS(PhanSo p)
    {
        PhanSo psCong = new PhanSo();
        psCong._tuSo = (this._tuSo*p._mauSo) + (this._mauSo * p._tuSo);
        psCong._mauSo = this._mauSo * p._mauSo;
        return psCong;
    }
    // Tru 2 phan so
    public PhanSo TruPS (PhanSo p)
    {
        PhanSo psTru = new PhanSo();
        psTru._tuSo = (this._tuSo*p._mauSo) - (this._mauSo * p._tuSo);
        psTru._mauSo = this._mauSo * p._mauSo;
        return psTru;
    }
    // Nhan 2 phan so
    public PhanSo NhanPS(PhanSo p)
    {
        PhanSo psNhan = new PhanSo();
        psNhan._tuSo = this._tuSo * p._tuSo;
        psNhan._mauSo = this._mauSo * p._mauSo;
        return psNhan;
    }
    // Thuong 2  phan so
    public PhanSo ThuongPS(PhanSo p)
    {
        PhanSo psThuong = new PhanSo();
        psThuong._tuSo = this._tuSo * p._mauSo;
        psThuong._mauSo = this._mauSo * p._tuSo;
        return psThuong;
    }
}
