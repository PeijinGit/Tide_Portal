<template>
  <div class="register-page">
    <div class="reg-pad">
      <div class="warn" v-show="!hasUsername">用户未填写</div>
      <p>
        <i class="fa fa-user fa-2x" aria-hidden="true"></i>
        <input
          type="text"
          name=""
          id=""
          v-model="username"
          placeholder="请输入昵称"
        />
      </p>
      <div class="warn" v-show="!hasPhoneNum">手机号码未填写</div>
      <p>
        <i class="fa fa-mobile fa-2x" aria-hidden="true"></i>
        <input
          type="text"
          name=""
          id=""
          v-model="phoneNum"
          placeholder="请输入手机号码"
        />
      </p>
      <div class="warn" v-show="!hasQQ">QQ未填写</div>
      <p>
        <i class="fa fa-qq fa-lg" aria-hidden="true"></i>
        <input type="text" name="" id="" v-model="QQ" placeholder="请输入QQ" />
      </p>
      <div class="warn"></div>
      <p>
        <i class="fa fa-transgender fa-lg" aria-hidden="true"></i>
        <select v-model="hasGender">
          <option value="0">女</option>
          <option value="1">男</option>
          <option value="2">其他</option>
        </select>
      </p>
      <div class="warn" v-show="!hasPwd">密码未填写</div>
      <p>
        <i class="fa fa-lock fa-2x" aria-hidden="true"></i>
        <input
          type="text"
          name=""
          id=""
          v-model="password"
          placeholder="请输入昵称"
        />
      </p>
      <div class="warn" v-show="!samePwd">两次密码不一致</div>
      <p>
        <i class="fa fa-lock fa-2x" aria-hidden="true"></i>
        <input
          type="text"
          name=""
          id=""
          v-model="conPassword"
          placeholder="请输入昵称"
        />
      </p>
      <p>
        <button @click="registerUer()">注册</button>
      </p>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      hasUsername: true,
      hasPhoneNum: true,
      hasQQ: true,
      hasPwd: true,
      samePwd: true,
      username: "",
      phoneNum: "",
      QQ: "",
      hasGender: "",
      password: "",
      conPassword: "",
    };
  },
  methods: {
    registerUer() {
      alert("adding" + this.QQ +" "+this.username);
      var that = this;
      if (this.password == this.conPassword) {
        this.$http.post(`https://localhost:44385/login/AddUserTest`, 
           //this.$qs.stringify (
            {
              myuser: {
                qq: this.QQ,
                name: this.username,
              }
            } 
          //)
        )
          .then((res)=>{
          console.log("add user"+res.data);
        });
      }
    },
  },
};
</script>

<style lang="scss" scoped>
* {
  padding: 0;
  margin: 0;
  box-sizing: border-box;
}
div {
  .register-page {
    position: relative;
    padding: 10px 40px;
    .reg-pad {
      .warn {
        color: red;
        font-size: 13px;
        height: 20px;
        width: 300px;
        line-height: 20px;
        padding: 0 6px;
      }
      p {
        overflow: hidden;
        i {
          background-color: #eee;
          width: 56px;
          height: 45px;
          line-height: 45px;
          float: left;
          border: 1px solid #ccc;
          border-right: 0 none;
          border-radius: 3px 0 0 3px;
          text-align: center;
        }
        input {
          height: 45px;
          width: 370px;
          float: left;
          border: 1px solid #ccc;
          border-left: 0 none;
          border-radius: 0 3px 3px 0;
          outline: none;
          padding: 0 6px;
        }
        select {
          height: 45px;
          width: 370px;
          float: left;
          border: 1px solid #ccc;
          border-left: 0 none;
          border-radius: 0 3px 3px 0;
          outline: none;
          padding: 0 6px;
        }
        button {
          height: 45px;
          width: 426px;
          float: left;
          background-color: rgb(255, 170, 139);
          border: 0 none;
          border-radius: 3px;
          outline: none;
          padding: 0 6px;
          margin-top: 20px;
        }
      }
    }
  }
}
</style>