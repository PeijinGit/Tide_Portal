<template>
      
  <div class="about">
    <!-- <div
      class="top-banner"
      style="height: 370px; background: url('/imgs/banner/关于我们.jpg')"
    ></div> -->
    <topBanner imgUrl="/imgs/banner/关于我们.jpg"/>
    <div class="about-us">
      <padTitle mTitle="公司介绍" sTitle="互联网+时代" />
      <div class="about-inner">
        <inner>
          <img src="/imgs/others/aboutTextImage.jpg" alt="" />
          <div class="about-detail-content" >
            <p>
              <b
                >{{about.introduce}}</b
              >
              <br />{{about.detail}}
            </p>
            <ul>
              <li v-for="item in about.services" :key="item.title">
                <span>{{item.title}}</span>
                <p>
                  {{item.text}}
                </p>
              </li>      
            </ul>
          </div>
        </inner>
      </div>
      <div class="about-contact">
        <inner width="880px">
          <padTitle mTitle="联系我们" />
          <img src="/imgs/icons/contact.jpg" alt="" />
          <div class="contact-detail">
            <p>企业 QQ：8888888</p>
            <p>企业微信：Apple-zhaoxijiaoyu</p>
            <p>电　　话：13163257325</p>
            <p>地　　址：江苏镇江润州区</p>
            <p>公司邮箱：xxx@zhaoxi.com</p>
            <p></p>
          </div>
        </inner>
      </div>
    </div>
    <!-- </topBanner> -->
  </div>
</template>

<script>

export default { 
  data() {
    return {
      about:{}
    }
  },
  mounted(){
    this.getAbout();
  },
  methods:{
    getAbout(){
      this.$getJsonResAsync("about", resData => {this.about = resData;})
    }
  }
};
</script>

<style lang="scss" scoped>

.about-us {
  background-color: #fff;
  padding-top: 20px;
  padding-bottom: 20px;
  img {
    float: left;
    width: 520px;
    height: 290px;
  }
  .about-detail-content {
    float: right;
    width: 600px;
    text-align: left;
    line-height: 25px;
    font-size: 14px;
    > p {
      margin: 0 0 20px 0;
    }
    ul {
      li {
        font-weight: bold;
        list-style: none;
        span {
          color: red;
        }
        p {
          display: inline-block;
        }
      }
    }
  }
}
.about-contact{
  background-color: #F6F6F6;
  overflow: hidden;
  img{
    float: left;
  }
  .contact-detail{
    float: left;
    margin-left: 80px;
    text-align: left;
    font-size: 16px;
    p{
      margin-bottom: 12px;
    }
  }
}
</style>
