using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8So_WindowsForms
{
    public class Node
    {
        
        public int[,] MaTran;// ma trận 8 số
        public int SoManhSai;//số mảnh sai vị trí của ma trận
        public int ChiSo;// chỉ số của node
        public int Cha;// cha của node, để truy vét kết quả
        public int fn;// chi phí đi đến node đó
    }
    public class C_8So
    {
        private int ChiSo = 0;//chỉ số của Node sẽ tăng sau mỗi lần sinh ra 1 node
        private int fn = 0;// Sau mỗi lần sinh ra các node thì chi phí các node tăng 1 đơn vị, tức node con sẽ có chi phí lớn hơn node cha 1 đơn vị
        public Stack<int[,]> timKetQua(int[,] MaTran, int n)
        {
            
            Stack<int[,]> stkKetQua = new Stack<int[,]>();

            List<Node> Close = new List<Node>();
            List<Node> Open = new List<Node>();

            //khai báo và khởi tạo cho node đầu tiên
            Node tSo = new Node();
            tSo.MaTran = MaTran;
            tSo.SoManhSai = soMiengSaiViTri(MaTran);
            tSo.ChiSo = 0;
            tSo.Cha = -1;
            tSo.fn = 0;
            //cho trạng thái đầu tiên vào Open;
            Open.Add(tSo);

            int t = 0;
            while(Open.Count!=0)
            {
                #region chọn node tốt nhất trong tập Open và chuyển nó sang Close
                tSo = new Node();
                tSo = Open[t];
                Open.Remove(tSo);
                Close.Add(tSo);
                #endregion

                //nếu node có số mảnh sai là 0, tức là đích thì thoát
                if (tSo.SoManhSai == 0) break;
                else
                {
                    //sinh hướng đi của node hiện tại
                    List<Node> lstHuongDi = new List<Node>();
                    lstHuongDi = sinhHuongDi(tSo);

                    for (int i = 0; i < lstHuongDi.Count; i++)
                    {
                        //hướng đi không thuộc Open và Close
                        if (!haiNodeTrungNhau(lstHuongDi[i], Open) && !haiNodeTrungNhau(lstHuongDi[i], Close))
                        {
                            Open.Add(lstHuongDi[i]);
                        }
                        else
                        {   //nếu hướng đi thuộc Open
                            if (haiNodeTrungNhau(lstHuongDi[i], Open))
                            {
                                /*nếu hướng đi đó tốt hơn thì sẽ được cập nhật lại, 
                                ngược lại thì sẽ không cập nhật*/
                                soSanhTotHon(lstHuongDi[i], Open);
                            }
                            else
                            {
                                //nếu hướng đi thuộc Close
                                if (haiNodeTrungNhau(lstHuongDi[i], Close))
                                {
                                    /*nếu hướng đi đó tốt hơn thì sẽ được cập nhật lại, 
                                    ngược lại thì sẽ không cập nhật và chuyển từ Close sang Open*/
                                    if (soSanhTotHon(lstHuongDi[i], Close))
                                    {
                                        Node temp = new Node();
                                        temp = layNodeTrungTrongClose(lstHuongDi[i], Close);
                                        Close.Remove(temp);
                                        Open.Add(temp);
                                    }
                                }
                            }
                        }

                    }

                    //chọn vị trí có phí tốt nhất trong Open
                    t = viTriTotNhatOpen(Open);
                }

            }

            //truy vét kết quả tỏng tập Close
            stkKetQua = truyVetKetQua(Close);

            return stkKetQua;
        }

        //truy vét kết quả đường đi trong tập Close
        Stack<int[,]> truyVetKetQua(List<Node> Close)
        {
            Stack<int[,]> ketQua = new Stack<int[,]>();

            int t = Close[Close.Count - 1].Cha;
            Node temp = new Node();
            ketQua.Push(Close[Close.Count - 1].MaTran);

            while (t != -1)
            {
                for (int i = 0; i < Close.Count; i++)
                {
                    if (t == Close[i].ChiSo)
                    {
                        temp = Close[i];
                        break;
                    }
                }

                ketQua.Push(temp.MaTran);
                t = temp.Cha;
            }

            return ketQua;
        }


        /// <summary>
        /// hàm sinh ra các hướng đi từ một node sinh ra các node con
        /// </summary>
        /// <param name="TamSo">node Cha</param>
        /// <returns>danh sách các hướng đi</returns>
        List<Node> sinhHuongDi(Node tSo)
        {
            int n = tSo.MaTran.GetLength(0);//lấy số hàng của ma trận

            List<Node> lstHuongDi = new List<Node>();

            #region  Xác định vị trí mảnh chống, có giá trị là 0
            int h = 0;
            int c = 0;
            bool ok = false;
            for (h = 0; h < n; h++)
            {
                for (c = 0; c < n; c++)
                    if (tSo.MaTran[h, c] == 0)
                    {
                        ok = true;
                        break;
                    }

                if (ok) break;
            }
            #endregion

            Node Temp = new Node();
            Temp.MaTran = new int[n, n];
            //Copy mảng Ma trận sang mảng ma trận tạm
            Array.Copy(tSo.MaTran, Temp.MaTran, tSo.MaTran.Length);

            fn++;// tăng chi phí của node con lên 1 đơn vị

            #region Xét các hướng đi theo 4 hướng: trên, dưới, phải, trái 
            //xét hàng ngang bắt đầu từ hàng thứ 2 trở đi
            if (h > 0 && h <= n - 1)
            {
                // thay đổi hướng đi của ma trận
                Temp.MaTran[h, c] = Temp.MaTran[h - 1, c];
                Temp.MaTran[h - 1, c] = 0;

                //cập nhật lại thông số của node
                Temp.SoManhSai = soMiengSaiViTri(Temp.MaTran);
                ChiSo++;
                Temp.ChiSo = ChiSo;
                Temp.Cha = tSo.ChiSo;
                Temp.fn = fn + Temp.SoManhSai;
                lstHuongDi.Add(Temp);

                //sau khi thay đổi ma trận thì copy lại ma trận cha cho MaTran để xét trường hợp tiếp theo
                Temp = new Node();
                Temp.MaTran = new int[n, n];
                Array.Copy(tSo.MaTran, Temp.MaTran, tSo.MaTran.Length);
            }
            //xét hàng ngang bắt đầu từ hàng thứ cuối cùng - 1 trở xuống
            if (h < n - 1 && h >= 0)
            {
                // thay đổi hướng đi của ma trận
                Temp.MaTran[h, c] = Temp.MaTran[h + 1, c];
                Temp.MaTran[h + 1, c] = 0;

                //cập nhật lại thông số của node
                Temp.SoManhSai = soMiengSaiViTri(Temp.MaTran);
                ChiSo++;
                Temp.ChiSo = ChiSo;
                Temp.Cha = tSo.ChiSo;
                Temp.fn = fn + Temp.SoManhSai;
                lstHuongDi.Add(Temp);

                //sau khi thay đổi ma trận thì copy lại ma trận cha cho MaTran để xét trường hợp tiếp theo
                Temp = new Node();
                Temp.MaTran = new int[n, n];
                Array.Copy(tSo.MaTran, Temp.MaTran, tSo.MaTran.Length);
            }
            //Xét cột dọc bắt đầu từ cột thứ 2 trở đi
            if (c > 0 && c <= n - 1)
            {
                // thay đổi hướng đi của ma trận
                Temp.MaTran[h, c] = Temp.MaTran[h, c - 1];
                Temp.MaTran[h, c - 1] = 0;

                //cập nhật lại thông số của node
                Temp.SoManhSai = soMiengSaiViTri(Temp.MaTran);
                ChiSo++;
                Temp.ChiSo = ChiSo;
                Temp.Cha = tSo.ChiSo;
                Temp.fn = fn + Temp.SoManhSai;
                lstHuongDi.Add(Temp);

                //sau khi thay đổi ma trận thì copy lại ma trận cha cho MaTran để xét trường hợp tiếp theo
                Temp = new Node();
                Temp.MaTran = new int[n, n];
                Array.Copy(tSo.MaTran, Temp.MaTran, tSo.MaTran.Length);
            }
            //Xét cột dọc bắt đầu từ cột cuối cùng -1 trở xuống
            if (c < n - 1 && c >= 0)
            {
                // thay đổi hướng đi của ma trận
                Temp.MaTran[h, c] = Temp.MaTran[h, c + 1];
                Temp.MaTran[h, c + 1] = 0;

                //cập nhật lại thông số của node
                Temp.SoManhSai = soMiengSaiViTri(Temp.MaTran);
                ChiSo++;
                Temp.ChiSo = ChiSo;
                Temp.Cha = tSo.ChiSo;
                Temp.fn = fn + Temp.SoManhSai;
                lstHuongDi.Add(Temp);

                //đến đây đã xết hết hướng đi nên không cần copy lại ma trận
            }
            #endregion

            return lstHuongDi;
        }

        
        /// <summary>
        /// Chọn vị trí có chi phí tốt nhất trong Open
        /// </summary>
        /// <param name="Open">Tập Open</param>
        /// <returns>Vị trí tốt nhất</returns>
        int viTriTotNhatOpen(List<Node> Open)
        {
            if (Open.Count != 0)
            {
                Node min = new Node();
                min = Open[0];
                int vt = 0;

                for (int i = 1; i < Open.Count; i++)
                    if (min.SoManhSai > Open[i].SoManhSai)
                    {
                        min = Open[i];
                        vt = i;
                    }
                    else
                    {
                        if (min.SoManhSai == Open[i].SoManhSai)
                        {
                            if (min.fn > Open[i].fn)
                            {
                                min = Open[i];
                                vt = i;
                            }
                        }
                    }
                return vt;
            }

            return 0;
        }


        /// <summary>
        /// So sánh chi phí của hai node
        /// </summary>
        /// <param name="TamSo">Node cần so sánh</param>
        /// <param name="lst8So">Tập Open hoặc Close</param>
        /// <returns>trả về true nếu tốt hơn và cập nhật lại cha và chi phí cho node, ngược lại không làm gì và trả về false </returns>
        bool soSanhTotHon(Node tSo, List<Node> lst8So)
        {
            for (int i = 0; i < lst8So.Count; i++)
                if (haiMaTranBangNhau(tSo.MaTran, lst8So[i].MaTran))
                {
                    if (tSo.fn < lst8So[i].fn)
                    {
                        //vì 2 ma trận bằng nhau lên số mảnh sai vi trị là như nhau lên ta không cần cập nhật
                        lst8So[i].Cha = tSo.Cha;// cập nhật lại cha của hướng đi
                        lst8So[i].fn = tSo.fn;// cập nhật lại chi phí đường đi

                        return true;
                    }
                    else return false;
                }

            return false;
        }


        /// <summary>
        /// Lấy ra node bị trùng trong tập Close
        /// </summary>
        /// <param name="TamSo">node trùng</param>
        /// <param name="lst8So">tập Close</param>
        /// <returns>Trả về node bị trùng</returns>
        Node layNodeTrungTrongClose(Node tSo, List<Node> lst8So)
        {
            Node Trung = new Node();
            for (int i = 0; i < lst8So.Count; i++)
                if (haiMaTranBangNhau(tSo.MaTran, lst8So[i].MaTran))
                {
                    Trung = lst8So[i];
                    break;
                }
            return Trung;
        }


        /// <summary>
        /// So sánh node này có trùng với 1 node trong danh sách các node khác không
        /// </summary>
        /// <param name="TamSo">node cần so sánh</param>
        /// <param name="lst8So">dánh sách các node cần so sánh</param>
        /// <returns>Trả về true nếu trùng, ngược lại trả về false </returns>
        bool haiNodeTrungNhau(Node tSo, List<Node> lst8So)
        {
            for (int i = 0; i < lst8So.Count; i++)
                if (haiMaTranBangNhau(lst8So[i].MaTran,tSo.MaTran))
                    return true;

            return false;
        }


        /// <summary>
        /// So sánh hai ma trận có các phần tử bằng nhau hay không
        /// </summary>
        /// <param name="a">Ma trận 1</param>
        /// <param name="b">Ma trận 2</param>
        /// <returns>Trả về true nếu bằng nhau ngược lại trả về false</returns>
        bool haiMaTranBangNhau(int[,] a, int[,] b)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                    if (a[i, j] != b[i, j])
                        return false;
            }

            return true;
        }


        /// <summary>
        /// trả về số mảnh nằm sai vị trí
        /// </summary>
        /// <param name="MaTran">Ma trận</param>
        /// <returns>Trả về số miếng sai vị trí</returns>
        int soMiengSaiViTri(int[,] MaTran)
        {
            int dung = 0;
            int t = 0;
            for (int i = 0; i < MaTran.GetLength(0); i++)
            {
                if (i == 0)
                    for (int j = 0; j < MaTran.GetLength(0); j++)
                    {
                        t++;
                        if (MaTran[i, j] == t)
                            dung++;
                    }
                else
                {
                    if (MaTran[1, 2] == 4)
                        dung++;
                    if (MaTran[2, 2] == 5)
                        dung++;
                    if (MaTran[2, 1] == 6)
                        dung++;
                    if (MaTran[2, 0] == 7)
                        dung++;
                    if (MaTran[1, 0] == 8)
                        dung++;

                    break;
                }
            }
            return 8-dung;
        }

        // sinh một ma trận ngẫu nhiên để làm node bắt đầu
        public int[,] randomMaTran(int kickThuoc)
        {
            
            int[,] MaTran = new int[kickThuoc, kickThuoc];
            //khởi tạo ma trận 8 số
            MaTran[0, 0] = 1;
            MaTran[0, 1] = 2;
            MaTran[0, 2] = 3;
            MaTran[1, 0] = 8;
            MaTran[1, 1] = 0;
            MaTran[1, 2] = 4;
            MaTran[2, 0] = 7;
            MaTran[2, 1] = 6;
            MaTran[2, 2] = 5;


            //tập Close lưu lại các hướng đã đi để đảm bảo sinh ra hướng đi mới không trùng lặp
            List<int[,]> Close = new List<int[,]>();

            int n = MaTran.GetLength(0);

            int[,] Temp = new int[n,n];
            Array.Copy(MaTran, Temp, MaTran.Length);
            Close.Add(Temp);
            int h = 1, c = 1;

            Random rd = new Random();

            int m = rd.Next(10, 200);//lấy số lần lặp sinh hướng đi
            int t = rd.Next(1, 5);// t=[1...4] tương ứng với 4 hướng đi

            //số lần lặp được lấy random từ đó số lượng hướng đi sẽ thay đổi theo
            for (int r = 0; r < m; r++)
            {
                // vì t được lấy random nên hướng đi sẽ ngẫu nhiên, có thể lên, xuống, trái, phải tùy vào biến t

                //đi lên trên với t =1
                if (h > 0 && h <= n - 1&&t==1)
                {
                    MaTran[h, c] = MaTran[h - 1, c];
                    MaTran[h - 1, c] = 0;
                    
                    if (!danhSachDaCoMaTran(MaTran, Close))
                    {
                        h--;
                        Temp = new int[n, n];
                        Array.Copy(MaTran, Temp, MaTran.Length);
                        Close.Add(Temp);
                    }
                    else
                    {
                        MaTran[h - 1, c] = MaTran[h, c];
                        MaTran[h, c] = 0;
                    }
       
                }

                t = rd.Next(1, 5);

                //đi sang trái với t=2
                if (c > 0 && c <= n - 1&&t==2)
                {
                    MaTran[h, c] = MaTran[h, c - 1];
                    MaTran[h, c - 1] = 0;
                    
                    if (!danhSachDaCoMaTran(MaTran, Close))
                    {
                        c--;
                        Temp = new int[n, n];
                        Array.Copy(MaTran, Temp, MaTran.Length);
                        Close.Add(Temp);
                    }
                    else
                    {
                        MaTran[h, c - 1] = MaTran[h, c];
                        MaTran[h, c] = 0;
                    }
                }

                t = rd.Next(1, 5);

                //đi xuống giưới với t=3
                if (h < n - 1 && h >= 0&&t==3)
                {
                    MaTran[h, c] = MaTran[h + 1, c];
                    MaTran[h + 1, c] = 0;

                    if (!danhSachDaCoMaTran(MaTran, Close))
                    {
                        h++;
                        Temp = new int[n, n];
                        Array.Copy(MaTran, Temp, MaTran.Length);
                        Close.Add(Temp);
                    }
                    else
                    {
                        MaTran[h + 1, c] = MaTran[h, c];
                        MaTran[h, c] = 0;
                    }

                }

                t = rd.Next(1, 5);

                //đi sang phải với t = 4
                if (c < n - 1 && c >= 0&&t==4)
                {
                    MaTran[h, c] = MaTran[h, c + 1];
                    MaTran[h, c + 1] = 0;
                    
                    if (!danhSachDaCoMaTran(MaTran, Close))
                    {
                        c++;
                        Temp = new int[n, n];
                        Array.Copy(MaTran, Temp, MaTran.Length);
                        Close.Add(Temp);
                    }
                    else
                    {
                        MaTran[h, c + 1] = MaTran[h, c];
                        MaTran[h, c] = 0;
                    }
                }

            }

            // trả về hướng đi cuối dùng trong danh sách hướng đi
            return Close[Close.Count-1];
        }
        
        //So sánh nếu ma trận a đã có trang danh sách Close  thì trả về true ngược lại trả về false
        bool danhSachDaCoMaTran(int[,] a, List<int[,]> Close)
        {
            for(int i=0;i<Close.Count;i++)
            {
                if(haiMaTranBangNhau(a,Close[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
