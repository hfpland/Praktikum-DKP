class data :
    def __init__ (self,email,password):
        self.email = email
        self.password = password
        self.data = {
            "haickalkelompok47@gmail.com" : {
                "email"     : "haickalkelompok47@gmail.com",
                "password"  : "12345",
                "role"      : "superadmin"
            },

            
        }
        self.history = {
            "haickalkelompok47@gmail.com":{
                "peminjaman_buku":{"Fisika Dasar","Dasar Komputer dan Pemrograman"},
                "tanggal_peminjaman" : "10-04-2020"
                },
            
            }

    def cek_login (self) :
        for value in self.data:
            if value == self.email: 
                call_data = self.data[value]
                if self.password == call_data["password"]:
                    return self.email
                else :
                    return False

    def out_login (self) :
        a = self.cek_login()
        if a:
            login = self.data[a]
            history = self.history[a]
            if login:
                print(f'Selamat Datang {login["role"]}')
                print(f'Logged in as : {login["email"]}')
                print()
                print(f'{login["email"]} Meminjam Buku :')
                print()
                for x in history["peminjaman_buku"]:
                    print(x)
                    print()
                print(f'Tanggal Peminjaman : {history["tanggal_peminjaman"]}')
        else :
            print("Invalid Login")