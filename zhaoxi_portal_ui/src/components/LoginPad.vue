<template>
      
  <div>
    <p>
      <span v-show="!hasQQ">没有输入QQ号</span>
      <input id="txtQQ" type="text" name="" v-model="qq" placeholder="请输入QQ" />
    </p>
    <p>
      <input
        id="txtPwd"
        type="password"
        name=""
        v-model="password"
        placeholder="请输入朝夕登录密码"
      />
    </p>
    <p>
      <input
        id="txtValidate"
        type="text"
        name=""
        v-model="validateCode"
        placeholder="请输入验证码"
      />
      <img :src="validateCodeUse" alt="验证码" @click="changeValidateCode" />
    </p>
    <p>
      <button @click="login">登录</button>
    </p>
  </div>
</template>
<script>
export default {
  data() {
    return {
      validateCodeUrl: "https://localhost:44385/Login/GetValidateCode",
      validateCodeUse: "",
      qq: "",
      password: "",
      validateCode: "",
      hasQQ: true,
      hasPwd: true,
      hasValidate: true,
    };
  },
  mounted() {
    this.changeValidateCode();
  },
  methods: {
    changeValidateCode() {
      //这里的random用来触发url的改变？
      this.validateCodeUse = this.validateCodeUrl + "?t=" + Math.random();
    },
    login() {
      //layer.msg("test");
      if (this.qq == "") this.hasQQ = false;
      else this.hasQQ = true;
      if (this.password == "") this.hasPwd = false;
      else this.hasPwd = true;
      if (this.validateCode == "") this.hasValidate = false;
      else this.hasValidate = true;
      if (!this.hasQQ || !this.hasPwd || !this.hasValidate) return;
      //this.$http.get(`http://localhost:4171/login/CheckLogin?qq=${qq}&pwd=${password}&validateString${validateCode}`)
      this.$http
        .get(`https://localhost:44385/login/CheckLogin`, {
          params: {
            qq: this.qq,
            pwd: this.password,
            validateString: this.validateCode,
          },
        })
        .then((res) => {
          if (res.status == 214) {
            layer.msg(res.data);
          } else if (res.status == 200) {
            localStorage["zxToken"] = res.data;
            history.go(0);
          }
        });
    },
  },
};
</script>
<style lang="scss" scoped>
div {
  padding: 28px;
  p {
    margin-bottom: 20px;
    height: 40px;
    input {
      height: 40px;
      width: 340px;
      box-sizing: border-box;
      border-radius: 3px;
      border: 1px solid #ccc;
      outline: none;
      padding: 0 6px;
    }
    button {
      width: 340px;
      box-sizing: border-box;
      height: 40px;
      border: 0 none;
      background-color: rgb(255, 138, 95);
      color: #fff;
      font-size: 18px;
      outline: none;
      border-radius: 3px;
      letter-spacing: 16px;
      cursor: pointer;
    }
    button:hover {
      background-color: #f40;
    }
    #txtValidate {
      vertical-align: bottom;
    }
    span {
      display: block;
      font-size: 12px;
      color: red;
      padding-bottom: 6px;
    }
  }
  p:nth-child(3) {
    input {
      width: 220px;
    }
  }
}
</style>