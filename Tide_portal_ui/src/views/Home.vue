<template>
  <div class="home">
    <div class="carousel" style="height:390px;width:100%;background-color:#ccc;overflow:hidden">
      <el-carousel :interval="5000" arrow="always" height="390px">
        <el-carousel-item v-for="item in Carousels" :key="item.url">
          <img :src="item.img" alt="">
        </el-carousel-item>
      </el-carousel>
    </div>
    <div class="home-pad">
      <div class="home-pad-inner">
        <padTitle mTitle= "朝夕名师 <span style='color:#eb7c06'>在线直播</span>" sTitle="直播互动学习，感受技术韵律"/>       
        <div class="public-course">
          <ul>
            <li v-for="item in publicCourses" :key="item.text">
            <a :href="item.url" target="_blank">
                <img :src="item.img" alt />
                <p>{{item.text}}</p>
              </a>
          </li>         
          </ul>
        </div>
        <padTitle mTitle= "朝夕6大<span style='color:#eb7c06'>贴心服务</span>" sTitle="学伴式专属服务，打造IT精英圈层"/>       
        <div class="company-service">
            <img src="/imgs/companyInfo/6大服务.png" alt="">
        </div>
        <padTitle mTitle= "加入<span style='color:#eb7c06'>朝夕</span>" sTitle="让每个人的职业生涯不留遗憾"/> 
        <div class="join-us">
          <ul>
            <!-- <li v-for="item in recruitSmall" :key="item.id">
              <a href="">
                <div>
                  <img :src="item.img" alt="">
                </div>
                <p class="recruit-title">{{item.title}}</p>
                <p class="recruit-text">{{item.text}}</p>
              </a>
            </li>   -->
            <router-link tag="li" :to="'/recruit?recruit='+(index+1)" v-for="(recruit,index) in recruitSmall" :key="recruit.id">
              <a href>
                <div>
                  <img :src="recruit.img" alt />
                </div>
                <p class="recruit-title">{{recruit.title}}</p>
                <p class="recruit-text">{{recruit.text}}</p>
              </a>
            </router-link>
          </ul>  
        </div> 
        <padTitle mTitle= "合作<span style='color:#eb7c06'>伙伴</span>" sTitle="人生道路伙伴不可或缺"/> 
        <div class="buddy-list">
          <ul>
            <li v-for="item in buddy" :key="item.img">
              <a href="">
                <img :src="item.img" alt="">
              </a>
            </li>
          </ul>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
// // @ is an alias to /src
// import padTitle from '@/components/PadTitle.vue'
var that;
export default {
  name: "home",
  data(){
    return{
      Carousels:[],
      publicCourses:[],
      recruitSmall:[],
      buddy:[],
    };
  },
  mounted() {
    that = this;
    this.getCarousel();
    this.getPublicCourses();
    this.getRecruitSmall();
    this.getBuddy();
  },
  methods:{
    getCarousel() {
     this.$getJsonResAsync("carousel", resData => {
        this.Carousels = resData;
      });
    },
    getPublicCourses() {
      this.$getJsonResAsync("public", resData => {
        that.publicCourses = resData;
      });
    },
    getRecruitSmall(){
      this.$getJsonResAsync("recruitSmall", resData => {
        that.recruitSmall = resData;
      });
    },
    getBuddy(){
      this.$getJsonResAsync("buddy", resData => {
        that.buddy = resData;
      });
    }
  }
};
</script>
<style lang="scss" scoped>

a {
  color:#333;
  text-decoration: none;
}

.home-pad{
  padding-top: 10px;
  margin-top: 60px;
  margin-bottom: 60px;
  .home-pad-inner{
    width: 88%;
    margin: auto;
    .public-course{
      margin-bottom: 110px;
      ul{
        text-align: center;
        li{
          list-style: none;
          display: inline-block;
          margin-left: 36px;
          margin-top: 36px;
          img{
            width: 288px;
          }
          p{
            font-size: 14px;
            text-align: center;
            padding: 6px;
          }
        }
      }
    }
    .company-service{
      margin-top: 60px;
      text-align: center;
      margin-bottom: 116px;
    }
    .join-us {
      margin-top: 68px;
      margin-bottom: 116px;
      ul {
        width: 1266px;
        margin: auto;
        text-align: center;
        li:nth-child(1) {
          margin-left: 0;
        }
        li {
          vertical-align: top;
          height: 320px;
          display: inline-block;
          margin-left: 100px;
          div {
            width: 224px;
            height: 224px;
            position: relative;
            overflow: hidden;
            img {
              position: relative;
              top: 0;
              left: 0;
              width: 224px;
              height: 224px;
              transition: 300ms;
            }
          }
          .recruit-title {
            text-align: center;
            font-size: 18px;
            font-weight: bold;
            padding: 6px 0;
          }
          .recruit-text {
            width: 224px;
            font-size: 14px;
            text-align: left;
            padding: 6px;
          }
        }
        li:hover {
          img {
            top: -31px;
            left: -31px;
            width: 286px;
            height: 286px;
          }
          .recruit-title {
            color: #eb7c06;
          }
        }
      }
    }
    .buddy-list{
      ul{
        width: 1266px;
        margin: auto;
        li{
          width: 176px;
          height: 56px;
          position: relative;
          top: 0;
          list-style: none;
          display: inline-block;
          margin-left: 28px;
          margin-top: 28px;
          cursor: pointer;
          transition: 0.5s;
        }
        li:hover{
          top: -10px;
          box-shadow: 0 6px 18px #999;
        }
      }
    }

    .carousel{
      
      .el-carousel__item h3 {
        color: #475669;
        font-size: 18px;
        opacity: 0.75;
        line-height: 300px;
        margin: 0;
      }
      
      .el-carousel__item:nth-child(2n) {
        background-color: #99a9bf;
      }
      
      .el-carousel__item:nth-child(2n+1) {
        background-color: #d3dce6;
      }
    }
  }
}
</style>


